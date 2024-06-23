using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x0200001C RID: 28
	[CompilerGenerated]
	internal static class CosturaShit
	{
		// Token: 0x06000082 RID: 130 RVA: 0x0000208A File Offset: 0x0000028A
		private static string CultureToString(CultureInfo culture)
		{
			if (culture == null)
			{
				return "";
			}
			return culture.Name;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008FA4 File Offset: 0x000071A4
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Assembly[] assemblies = currentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(CosturaShit.CultureToString(name2.CultureInfo), CosturaShit.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009020 File Offset: 0x00007220
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009058 File Offset: 0x00007258
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						CosturaShit.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						return memoryStream;
					}
				}
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000090F0 File Offset: 0x000072F0
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return CosturaShit.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00009114 File Offset: 0x00007314
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000913C File Offset: 0x0000733C
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = CosturaShit.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = CosturaShit.ReadStream(stream);
			}
			using (Stream stream2 = CosturaShit.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = CosturaShit.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009220 File Offset: 0x00007420
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = CosturaShit.nullCacheLock;
			lock (obj)
			{
				if (CosturaShit.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = CosturaShit.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = CosturaShit.ReadFromEmbeddedResources(CosturaShit.assemblyNames, CosturaShit.symbolNames, assemblyName);
			if (assembly == null)
			{
				object obj2 = CosturaShit.nullCacheLock;
				lock (obj2)
				{
					CosturaShit.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00009310 File Offset: 0x00007510
		// Note: this type is marked as 'beforefieldinit'.
		static CosturaShit()
		{
			CosturaShit.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			CosturaShit.symbolNames.Add("costura", "costura.costura.pdb.compressed");
			CosturaShit.assemblyNames.Add("dotnetzip", "costura.dotnetzip.dll.compressed");
			CosturaShit.symbolNames.Add("dotnetzip", "costura.dotnetzip.pdb.compressed");
			CosturaShit.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000093DC File Offset: 0x000075DC
		public static void Attach()
		{
			if (Interlocked.Exchange(ref CosturaShit.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += CosturaShit.ResolveAssembly;
		}

		// Token: 0x04000154 RID: 340
		private static object nullCacheLock = new object();

		// Token: 0x04000155 RID: 341
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x04000156 RID: 342
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x04000157 RID: 343
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x04000158 RID: 344
		private static int isAttached;
	}
}

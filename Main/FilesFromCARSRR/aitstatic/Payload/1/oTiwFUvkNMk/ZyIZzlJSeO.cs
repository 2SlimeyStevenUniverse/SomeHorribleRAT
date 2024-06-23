using System;
using System.IO;
using System.IO.Compression;

namespace oTiwFUvkNMk
{
	// Token: 0x0200001C RID: 28
	public static class ZyIZzlJSeO
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000058E0 File Offset: 0x00003AE0
		public static byte[] WMJpHfchztXHpU(byte[] wwgeLzQUyokdILh)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(wwgeLzQUyokdILh))
			{
				byte[] array = new byte[4];
				memoryStream.Read(array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					byte[] array2 = new byte[num];
					gzipStream.Read(array2, 0, num);
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000596C File Offset: 0x00003B6C
		public static byte[] GZrqNIdOyU(byte[] nDDxmJVPHLh)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				byte[] bytes = BitConverter.GetBytes(nDDxmJVPHLh.Length);
				memoryStream.Write(bytes, 0, 4);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
				{
					gzipStream.Write(nDDxmJVPHLh, 0, nDDxmJVPHLh.Length);
					gzipStream.Flush();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}
}

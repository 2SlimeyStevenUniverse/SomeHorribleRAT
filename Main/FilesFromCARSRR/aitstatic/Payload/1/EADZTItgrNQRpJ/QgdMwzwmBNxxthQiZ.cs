using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace EADZTItgrNQRpJ
{
	// Token: 0x02000011 RID: 17
	public class Dekryptor
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000040F4 File Offset: 0x000022F4
		public Dekryptor(string eGjmtGXifcREm)
		{
			if (string.IsNullOrEmpty(eGjmtGXifcREm))
			{
				throw new ArgumentException("masterKey can not be null or empty.");
			}
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(eGjmtGXifcREm, Dekryptor.fHFpJscAvWyuQatG, 50000))
			{
				this.tAjHiaaMoRM = rfc2898DeriveBytes.GetBytes(32);
				this.OWhTwVenIpTFVj = rfc2898DeriveBytes.GetBytes(64);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002256 File Offset: 0x00000456
		public string rOsBZTEUNxQQTxt(string VJohKFaOdOc)
		{
			return Convert.ToBase64String(this.GIXukyxnZDvudY(Encoding.UTF8.GetBytes(VJohKFaOdOc)));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000416C File Offset: 0x0000236C
		public byte[] GIXukyxnZDvudY(byte[] vOTDOHJVMybZE)
		{
			if (vOTDOHJVMybZE == null)
			{
				throw new ArgumentNullException("input can not be null.");
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Position = 32L;
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.KeySize = 256;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = this.tAjHiaaMoRM;
					aesCryptoServiceProvider.GenerateIV();
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
					{
						memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
						cryptoStream.Write(vOTDOHJVMybZE, 0, vOTDOHJVMybZE.Length);
						cryptoStream.FlushFinalBlock();
						using (HMACSHA256 hmacsha = new HMACSHA256(this.OWhTwVenIpTFVj))
						{
							byte[] array = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
							memoryStream.Position = 0L;
							memoryStream.Write(array, 0, array.Length);
						}
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000226E File Offset: 0x0000046E
		public string RQoflJSBgJj(string dmvtgqpcDQI)
		{
			return Encoding.UTF8.GetString(this.xQTSAulYfvvErj(Convert.FromBase64String(dmvtgqpcDQI)));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000042C4 File Offset: 0x000024C4
		public byte[] xQTSAulYfvvErj(byte[] JTikyhGHZNSh)
		{
			if (JTikyhGHZNSh == null)
			{
				throw new ArgumentNullException("input can not be null.");
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(JTikyhGHZNSh))
			{
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.KeySize = 256;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = this.tAjHiaaMoRM;
					using (HMACSHA256 hmacsha = new HMACSHA256(this.OWhTwVenIpTFVj))
					{
						byte[] kkkcxoFCxWKZyrc = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
						byte[] array = new byte[32];
						memoryStream.Read(array, 0, array.Length);
						if (!this.rmnxWDsTCGNcA(kkkcxoFCxWKZyrc, array))
						{
							throw new CryptographicException("Invalid message authentication code (MAC).");
						}
					}
					byte[] array2 = new byte[16];
					memoryStream.Read(array2, 0, 16);
					aesCryptoServiceProvider.IV = array2;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
					{
						byte[] array3 = new byte[memoryStream.Length - 16L + 1L];
						byte[] array4 = new byte[cryptoStream.Read(array3, 0, array3.Length)];
						Buffer.BlockCopy(array3, 0, array4, 0, array4.Length);
						result = array4;
					}
				}
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004484 File Offset: 0x00002684
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private bool rmnxWDsTCGNcA(byte[] kkkcxoFCxWKZyrc, byte[] eCPkoicWdc)
		{
			bool result = true;
			for (int i = 0; i < kkkcxoFCxWKZyrc.Length; i++)
			{
				if (kkkcxoFCxWKZyrc[i] != eCPkoicWdc[i])
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000026 RID: 38
		private const int aMEWfLMidq = 32;

		// Token: 0x04000027 RID: 39
		private const int SxTnjGmlnzArHZE = 64;

		// Token: 0x04000028 RID: 40
		private const int PuuAqojwNfqj = 16;

		// Token: 0x04000029 RID: 41
		private const int EydzmYTbJOUQdJ = 32;

		// Token: 0x0400002A RID: 42
		private readonly byte[] tAjHiaaMoRM;

		// Token: 0x0400002B RID: 43
		private readonly byte[] OWhTwVenIpTFVj;

		// Token: 0x0400002C RID: 44
		private static readonly byte[] fHFpJscAvWyuQatG = new byte[]
		{
			191,
			235,
			30,
			86,
			251,
			205,
			151,
			59,
			178,
			25,
			2,
			36,
			48,
			165,
			120,
			67,
			0,
			61,
			86,
			68,
			210,
			30,
			98,
			185,
			212,
			241,
			128,
			231,
			230,
			195,
			57,
			65
		};
	}
}

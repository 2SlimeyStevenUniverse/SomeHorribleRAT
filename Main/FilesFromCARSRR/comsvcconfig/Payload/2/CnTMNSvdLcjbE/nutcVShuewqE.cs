using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace CnTMNSvdLcjbE
{
	// Token: 0x02000011 RID: 17
	public class Dekryptor
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000040F4 File Offset: 0x000022F4
		public Dekryptor(string cQtMjAvHVaMx)
		{
			if (string.IsNullOrEmpty(cQtMjAvHVaMx))
			{
				throw new ArgumentException("masterKey can not be null or empty.");
			}
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(cQtMjAvHVaMx, Dekryptor.AIEiBLYtEulcH, 50000))
			{
				this.UZTdZMkPYK = rfc2898DeriveBytes.GetBytes(32);
				this.ACbYRDQRgPL = rfc2898DeriveBytes.GetBytes(64);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002256 File Offset: 0x00000456
		public string kZqXzZaMEdCk(string rlQtYPuFGqeL)
		{
			return Convert.ToBase64String(this.bitMRUmyTtUPU(Encoding.UTF8.GetBytes(rlQtYPuFGqeL)));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000416C File Offset: 0x0000236C
		public byte[] bitMRUmyTtUPU(byte[] kLAKAWenzfauiC)
		{
			if (kLAKAWenzfauiC == null)
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
					aesCryptoServiceProvider.Key = this.UZTdZMkPYK;
					aesCryptoServiceProvider.GenerateIV();
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
					{
						memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
						cryptoStream.Write(kLAKAWenzfauiC, 0, kLAKAWenzfauiC.Length);
						cryptoStream.FlushFinalBlock();
						using (HMACSHA256 hmacsha = new HMACSHA256(this.ACbYRDQRgPL))
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
		public string aoujYcGZtULlK(string pasefRqZaOnv)
		{
			return Encoding.UTF8.GetString(this.gojudhMCCPyqE(Convert.FromBase64String(pasefRqZaOnv)));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000042C4 File Offset: 0x000024C4
		public byte[] gojudhMCCPyqE(byte[] oBNsFURoqlIPIEPp)
		{
			if (oBNsFURoqlIPIEPp == null)
			{
				throw new ArgumentNullException("input can not be null.");
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(oBNsFURoqlIPIEPp))
			{
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.KeySize = 256;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = this.UZTdZMkPYK;
					using (HMACSHA256 hmacsha = new HMACSHA256(this.ACbYRDQRgPL))
					{
						byte[] gTfPFnmsbYfIPVo = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
						byte[] array = new byte[32];
						memoryStream.Read(array, 0, array.Length);
						if (!this.fJagdLPtKcBc(gTfPFnmsbYfIPVo, array))
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
		private bool fJagdLPtKcBc(byte[] gTfPFnmsbYfIPVo, byte[] EXupjwHTatnv)
		{
			bool result = true;
			for (int i = 0; i < gTfPFnmsbYfIPVo.Length; i++)
			{
				if (gTfPFnmsbYfIPVo[i] != EXupjwHTatnv[i])
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000026 RID: 38
		private const int ozOTFoIiCnkT = 32;

		// Token: 0x04000027 RID: 39
		private const int MDQgIwsOhmw = 64;

		// Token: 0x04000028 RID: 40
		private const int qwFfPQcPYv = 16;

		// Token: 0x04000029 RID: 41
		private const int yAHetMlMANsFG = 32;

		// Token: 0x0400002A RID: 42
		private readonly byte[] UZTdZMkPYK;

		// Token: 0x0400002B RID: 43
		private readonly byte[] ACbYRDQRgPL;

		// Token: 0x0400002C RID: 44
		private static readonly byte[] AIEiBLYtEulcH = new byte[]
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

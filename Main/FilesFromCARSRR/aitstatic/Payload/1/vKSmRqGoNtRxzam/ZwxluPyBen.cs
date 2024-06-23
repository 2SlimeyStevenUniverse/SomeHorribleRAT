using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace vKSmRqGoNtRxzam
{
	// Token: 0x02000007 RID: 7
	public static class ZwxluPyBen
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000366C File Offset: 0x0000186C
		public static string LCLBUmJiAegcc()
		{
			string result;
			try
			{
				result = ZwxluPyBen.mfmhIDrdbfijHhVz(string.Concat(new object[]
				{
					Environment.ProcessorCount,
					Environment.UserName,
					Environment.MachineName,
					Environment.OSVersion,
					new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize
				}));
			}
			catch
			{
				result = "Err HWID";
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000036F0 File Offset: 0x000018F0
		public static string mfmhIDrdbfijHhVz(string qpbsOVOxvkFPCrT)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] array = Encoding.ASCII.GetBytes(qpbsOVOxvkFPCrT);
			array = hashAlgorithm.ComputeHash(array);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString().Substring(0, 20).ToUpper();
		}
	}
}

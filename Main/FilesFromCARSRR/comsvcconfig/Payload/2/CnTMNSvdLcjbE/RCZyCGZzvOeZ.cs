using System;
using System.Security.Cryptography;
using System.Text;

namespace CnTMNSvdLcjbE
{
	// Token: 0x02000012 RID: 18
	public static class RCZyCGZzvOeZ
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000044B4 File Offset: 0x000026B4
		public static string DrCiTTRdzOSyd(string FgdXlKaLEqKjN)
		{
			byte[] array = Encoding.UTF8.GetBytes(FgdXlKaLEqKjN);
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				array = sha256Managed.ComputeHash(array);
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString().ToUpper();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004540 File Offset: 0x00002740
		public static byte[] HnnsZKvhXXowC(byte[] PRFWDOugMvpQi)
		{
			byte[] result;
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				result = sha256Managed.ComputeHash(PRFWDOugMvpQi);
			}
			return result;
		}
	}
}

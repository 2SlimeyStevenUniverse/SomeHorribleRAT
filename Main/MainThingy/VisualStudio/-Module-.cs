using System;
using System.Security.Cryptography;
using System.Text;
using Costura;

// Token: 0x02000001 RID: 1
internal class Decoder
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	static Decoder()
	{
		CosturaShit.Attach();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000020A4 File Offset: 0x000002A4
	public static string Decode(string faggotry1)
	{
		byte[] array = Convert.FromBase64String(faggotry1);
		byte[] key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes("ua1UkgOth0SkSTJZaefr8BqQ7EySs09fraY7cTyz7"));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		tripleDESCryptoServiceProvider.Clear();
		return Encoding.UTF8.GetString(bytes);
	}
}

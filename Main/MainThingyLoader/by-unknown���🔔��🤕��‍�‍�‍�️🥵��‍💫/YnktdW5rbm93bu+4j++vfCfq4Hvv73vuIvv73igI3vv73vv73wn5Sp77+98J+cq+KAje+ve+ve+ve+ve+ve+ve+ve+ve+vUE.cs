using System;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000001 RID: 1
internal class Decoder
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002604 File Offset: 0x00000804
	public static string Decode(string argument)
	{

        /*
		byte[] array = Convert.FromBase64String(argument);
		byte[] key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes("f1pfco5eq5wvh5p6tbtaafx2x7xer4naunczubzby"));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		tripleDESCryptoServiceProvider.Clear();
		return Encoding.UTF8.GetString(bytes);

		*/
        // decryptor from the tmm file

        byte[] array = Convert.FromBase64String(argument);
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

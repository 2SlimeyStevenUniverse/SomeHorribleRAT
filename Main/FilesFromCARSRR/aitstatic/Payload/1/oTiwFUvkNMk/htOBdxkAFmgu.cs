using System;
using System.IO;

namespace oTiwFUvkNMk
{
	// Token: 0x0200001A RID: 26
	internal class htOBdxkAFmgu
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00005520 File Offset: 0x00003720
		public static string wGIcTvVYqINJ(Stream lSrIqcUfFVZqz, int nKmzvQMmNxEC)
		{
			byte[] array = new byte[nKmzvQMmNxEC];
			lSrIqcUfFVZqz.Read(array, 0, nKmzvQMmNxEC);
			return tEcAUWUzShC.pdczpGWNWeHLEyY(array);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000258F File Offset: 0x0000078F
		public static string XYyCVFgPhgsmC(Stream MRjbmGZSUFhu)
		{
			return htOBdxkAFmgu.UPWYiXtRhmnIZO((byte)MRjbmGZSUFhu.ReadByte(), MRjbmGZSUFhu);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005544 File Offset: 0x00003744
		public static string UPWYiXtRhmnIZO(byte xFQUOEgPAhZWS, Stream krESUeDealAO)
		{
			int num = 0;
			byte[] array;
			if (xFQUOEgPAhZWS >= 160 && xFQUOEgPAhZWS <= 191)
			{
				num = (int)(xFQUOEgPAhZWS - 160);
			}
			else if (xFQUOEgPAhZWS == 217)
			{
				num = krESUeDealAO.ReadByte();
			}
			else if (xFQUOEgPAhZWS == 218)
			{
				array = new byte[2];
				krESUeDealAO.Read(array, 0, 2);
				array = tEcAUWUzShC.YPOqnNyIftMNvsQ(array);
				num = (int)BitConverter.ToUInt16(array, 0);
			}
			else if (xFQUOEgPAhZWS == 219)
			{
				array = new byte[4];
				krESUeDealAO.Read(array, 0, 4);
				array = tEcAUWUzShC.YPOqnNyIftMNvsQ(array);
				num = BitConverter.ToInt32(array, 0);
			}
			array = new byte[num];
			krESUeDealAO.Read(array, 0, num);
			return tEcAUWUzShC.pdczpGWNWeHLEyY(array);
		}
	}
}

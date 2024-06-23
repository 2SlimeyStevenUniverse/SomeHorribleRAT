using System;
using System.Text;

namespace oTiwFUvkNMk
{
	// Token: 0x02000015 RID: 21
	public class tEcAUWUzShC
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000229F File Offset: 0x0000049F
		public static byte[] UFfYIEanXEB(string nSAWNAFNVSi)
		{
			return tEcAUWUzShC.LASrcuIctKQXk.GetBytes(nSAWNAFNVSi);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022AC File Offset: 0x000004AC
		public static string pdczpGWNWeHLEyY(byte[] XsjVzAzzCyF)
		{
			return tEcAUWUzShC.LASrcuIctKQXk.GetString(XsjVzAzzCyF);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004580 File Offset: 0x00002780
		public static string EMJnHkZqbMM(byte[] noambVKVUJR)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in noambVKVUJR)
			{
				stringBuilder.Append(string.Format("{0:D3} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000045C8 File Offset: 0x000027C8
		public static string QXIFmSGquCtO(byte[] WzoxOljbxsH)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in WzoxOljbxsH)
			{
				stringBuilder.Append(string.Format("{0:X2} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004610 File Offset: 0x00002810
		public static byte[] YPOqnNyIftMNvsQ(byte[] EqiTgyEFguHwBZ)
		{
			byte[] array = new byte[EqiTgyEFguHwBZ.Length];
			int num = EqiTgyEFguHwBZ.Length - 1;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = EqiTgyEFguHwBZ[num];
				num--;
			}
			return array;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022B9 File Offset: 0x000004B9
		public static byte[] VeASIKTnGbyBn(long lHYQkLVdfgXY)
		{
			return tEcAUWUzShC.YPOqnNyIftMNvsQ(BitConverter.GetBytes(lHYQkLVdfgXY));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022C6 File Offset: 0x000004C6
		public static byte[] cuzERRMgbHRIht(int BVfXzczPHr)
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				(byte)BVfXzczPHr
			};
			array[2] = (byte)(BVfXzczPHr >> 8);
			array[1] = (byte)(BVfXzczPHr >> 16);
			array[0] = (byte)(BVfXzczPHr >> 24);
			return array;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000022EA File Offset: 0x000004EA
		public static byte[] bHOLARbRaeA(short zaNmwClxhugVD)
		{
			byte[] array = new byte[]
			{
				0,
				(byte)zaNmwClxhugVD
			};
			array[0] = (byte)(zaNmwClxhugVD >> 8);
			return array;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022FE File Offset: 0x000004FE
		public static byte[] YwcfYDrfpymykcWh(double iZRiDionjlVHg)
		{
			return tEcAUWUzShC.YPOqnNyIftMNvsQ(BitConverter.GetBytes(iZRiDionjlVHg));
		}

		// Token: 0x0400002E RID: 46
		private static UTF8Encoding LASrcuIctKQXk = new UTF8Encoding();
	}
}

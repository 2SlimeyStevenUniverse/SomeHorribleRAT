using System;
using System.Text;

namespace qpHzgmGhIMQpXfPi
{
	// Token: 0x02000015 RID: 21
	public class mqKnhiBubOI
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000229F File Offset: 0x0000049F
		public static byte[] TmMdetRcax(string brwedpqiCz)
		{
			return mqKnhiBubOI.iSJizlrskFk.GetBytes(brwedpqiCz);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022AC File Offset: 0x000004AC
		public static string yZRenfoHsNUTRf(byte[] gwjpAYEPhhVQLh)
		{
			return mqKnhiBubOI.iSJizlrskFk.GetString(gwjpAYEPhhVQLh);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004580 File Offset: 0x00002780
		public static string AnfjtGdQaeBSVY(byte[] ueandTAMSo)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in ueandTAMSo)
			{
				stringBuilder.Append(string.Format("{0:D3} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000045C8 File Offset: 0x000027C8
		public static string OfegKTUrXW(byte[] BbfSsbRhaEYC)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in BbfSsbRhaEYC)
			{
				stringBuilder.Append(string.Format("{0:X2} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004610 File Offset: 0x00002810
		public static byte[] rVJUJPMztaK(byte[] FPNUZfJIQgFM)
		{
			byte[] array = new byte[FPNUZfJIQgFM.Length];
			int num = FPNUZfJIQgFM.Length - 1;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = FPNUZfJIQgFM[num];
				num--;
			}
			return array;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022B9 File Offset: 0x000004B9
		public static byte[] pQSnDLGyuzTGsjgin(long fHRoUfpTJnUrwCM)
		{
			return mqKnhiBubOI.rVJUJPMztaK(BitConverter.GetBytes(fHRoUfpTJnUrwCM));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022C6 File Offset: 0x000004C6
		public static byte[] OKrUBnOBzyj(int peiZtLbkjJl)
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				(byte)peiZtLbkjJl
			};
			array[2] = (byte)(peiZtLbkjJl >> 8);
			array[1] = (byte)(peiZtLbkjJl >> 16);
			array[0] = (byte)(peiZtLbkjJl >> 24);
			return array;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000022EA File Offset: 0x000004EA
		public static byte[] xrEXYEveJMEzH(short GQzDARxCBPmAv)
		{
			byte[] array = new byte[]
			{
				0,
				(byte)GQzDARxCBPmAv
			};
			array[0] = (byte)(GQzDARxCBPmAv >> 8);
			return array;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022FE File Offset: 0x000004FE
		public static byte[] iaUKRoUlvFaEU(double AvegtQJrpS)
		{
			return mqKnhiBubOI.rVJUJPMztaK(BitConverter.GetBytes(AvegtQJrpS));
		}

		// Token: 0x0400002E RID: 46
		private static UTF8Encoding iSJizlrskFk = new UTF8Encoding();
	}
}

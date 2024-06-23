using System;
using System.IO;

namespace qpHzgmGhIMQpXfPi
{
	// Token: 0x0200001B RID: 27
	internal class NHzNXCXPdpUxEo
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000259E File Offset: 0x0000079E
		public static void QurqWauasRtDIurm(Stream RBBBHKMHLsBrkyw)
		{
			RBBBHKMHLsBrkyw.WriteByte(192);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005604 File Offset: 0x00003804
		public static void XVIrKADHbHgqh(Stream bSIFzBCeNNbdm, string ITfPsmPBYocZ)
		{
			byte[] array = mqKnhiBubOI.TmMdetRcax(ITfPsmPBYocZ);
			int num = array.Length;
			if (num <= 31)
			{
				byte value = (byte)(160 + (byte)num);
				bSIFzBCeNNbdm.WriteByte(value);
			}
			else if (num <= 255)
			{
				byte value = 217;
				bSIFzBCeNNbdm.WriteByte(value);
				value = (byte)num;
				bSIFzBCeNNbdm.WriteByte(value);
			}
			else if (num <= 65535)
			{
				byte value = 218;
				bSIFzBCeNNbdm.WriteByte(value);
				byte[] array2 = mqKnhiBubOI.rVJUJPMztaK(BitConverter.GetBytes((short)num));
				bSIFzBCeNNbdm.Write(array2, 0, array2.Length);
			}
			else
			{
				byte value = 219;
				bSIFzBCeNNbdm.WriteByte(value);
				byte[] array2 = mqKnhiBubOI.rVJUJPMztaK(BitConverter.GetBytes(num));
				bSIFzBCeNNbdm.Write(array2, 0, array2.Length);
			}
			bSIFzBCeNNbdm.Write(array, 0, array.Length);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000056CC File Offset: 0x000038CC
		public static void kiHUUjHLpgpzyi(Stream RDJjAeOKIJUcR, byte[] UJVeAdGSxYsLK)
		{
			int num = UJVeAdGSxYsLK.Length;
			if (num <= 255)
			{
				byte value = 196;
				RDJjAeOKIJUcR.WriteByte(value);
				value = (byte)num;
				RDJjAeOKIJUcR.WriteByte(value);
			}
			else if (num <= 65535)
			{
				byte value = 197;
				RDJjAeOKIJUcR.WriteByte(value);
				byte[] array = mqKnhiBubOI.rVJUJPMztaK(BitConverter.GetBytes((short)num));
				RDJjAeOKIJUcR.Write(array, 0, array.Length);
			}
			else
			{
				byte value = 198;
				RDJjAeOKIJUcR.WriteByte(value);
				byte[] array = mqKnhiBubOI.rVJUJPMztaK(BitConverter.GetBytes(num));
				RDJjAeOKIJUcR.Write(array, 0, array.Length);
			}
			RDJjAeOKIJUcR.Write(UJVeAdGSxYsLK, 0, UJVeAdGSxYsLK.Length);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000025AB File Offset: 0x000007AB
		public static void SqNZZfTqrJ(Stream CqNJHkgSvxKU, double wsGqsTGLYQQh)
		{
			CqNJHkgSvxKU.WriteByte(203);
			CqNJHkgSvxKU.Write(mqKnhiBubOI.iaUKRoUlvFaEU(wsGqsTGLYQQh), 0, 8);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000025C6 File Offset: 0x000007C6
		public static void IcBudJAjjQAgL(Stream yYUBViSuwbe, float aGDKgjIdPCS)
		{
			yYUBViSuwbe.WriteByte(202);
			yYUBViSuwbe.Write(mqKnhiBubOI.rVJUJPMztaK(BitConverter.GetBytes(aGDKgjIdPCS)), 0, 4);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000025E6 File Offset: 0x000007E6
		public static void GTfcAUnFuSEbXLi(Stream ZnQZzctslEh, bool sasOpuzLeQM)
		{
			if (sasOpuzLeQM)
			{
				ZnQZzctslEh.WriteByte(195);
				return;
			}
			ZnQZzctslEh.WriteByte(194);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000576C File Offset: 0x0000396C
		public static void zPmTQSUeisehDPWO(Stream TOxJaLFVTUCc, ulong jiKsomuRUkpgWc)
		{
			TOxJaLFVTUCc.WriteByte(207);
			byte[] bytes = BitConverter.GetBytes(jiKsomuRUkpgWc);
			TOxJaLFVTUCc.Write(mqKnhiBubOI.rVJUJPMztaK(bytes), 0, 8);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000579C File Offset: 0x0000399C
		public static void oxPpWXfaYU(Stream htOAEjKpLOS, long bVrVGsVLDhnvY)
		{
			if (bVrVGsVLDhnvY >= 0L)
			{
				if (bVrVGsVLDhnvY <= 127L)
				{
					htOAEjKpLOS.WriteByte((byte)bVrVGsVLDhnvY);
					return;
				}
				if (bVrVGsVLDhnvY <= 255L)
				{
					htOAEjKpLOS.WriteByte(204);
					htOAEjKpLOS.WriteByte((byte)bVrVGsVLDhnvY);
					return;
				}
				if (bVrVGsVLDhnvY <= 65535L)
				{
					htOAEjKpLOS.WriteByte(205);
					htOAEjKpLOS.Write(mqKnhiBubOI.xrEXYEveJMEzH((short)bVrVGsVLDhnvY), 0, 2);
					return;
				}
				if (bVrVGsVLDhnvY <= 255)
				{
					htOAEjKpLOS.WriteByte(206);
					htOAEjKpLOS.Write(mqKnhiBubOI.OKrUBnOBzyj((int)bVrVGsVLDhnvY), 0, 4);
					return;
				}
				htOAEjKpLOS.WriteByte(211);
				htOAEjKpLOS.Write(mqKnhiBubOI.pQSnDLGyuzTGsjgin(bVrVGsVLDhnvY), 0, 8);
				return;
			}
			else
			{
				if (bVrVGsVLDhnvY <= -2147483648L)
				{
					htOAEjKpLOS.WriteByte(211);
					htOAEjKpLOS.Write(mqKnhiBubOI.pQSnDLGyuzTGsjgin(bVrVGsVLDhnvY), 0, 8);
					return;
				}
				if (bVrVGsVLDhnvY <= -32768L)
				{
					htOAEjKpLOS.WriteByte(210);
					htOAEjKpLOS.Write(mqKnhiBubOI.OKrUBnOBzyj((int)bVrVGsVLDhnvY), 0, 4);
					return;
				}
				if (bVrVGsVLDhnvY <= -128L)
				{
					htOAEjKpLOS.WriteByte(209);
					htOAEjKpLOS.Write(mqKnhiBubOI.xrEXYEveJMEzH((short)bVrVGsVLDhnvY), 0, 2);
					return;
				}
				if (bVrVGsVLDhnvY <= -32L)
				{
					htOAEjKpLOS.WriteByte(208);
					htOAEjKpLOS.WriteByte((byte)bVrVGsVLDhnvY);
					return;
				}
				htOAEjKpLOS.WriteByte((byte)bVrVGsVLDhnvY);
				return;
			}
		}
	}
}

using System;
using System.IO;

namespace oTiwFUvkNMk
{
	// Token: 0x0200001B RID: 27
	internal class zbFTmTjDNABfl
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000259E File Offset: 0x0000079E
		public static void lQQjbkqpIeBOXQ(Stream SevQCAJfaphzbD)
		{
			SevQCAJfaphzbD.WriteByte(192);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005604 File Offset: 0x00003804
		public static void mzkIbdfzZltgUu(Stream NmaWtEkytZ, string TzAghYRXxhwUGV)
		{
			byte[] array = tEcAUWUzShC.UFfYIEanXEB(TzAghYRXxhwUGV);
			int num = array.Length;
			if (num <= 31)
			{
				byte value = (byte)(160 + (byte)num);
				NmaWtEkytZ.WriteByte(value);
			}
			else if (num <= 255)
			{
				byte value = 217;
				NmaWtEkytZ.WriteByte(value);
				value = (byte)num;
				NmaWtEkytZ.WriteByte(value);
			}
			else if (num <= 65535)
			{
				byte value = 218;
				NmaWtEkytZ.WriteByte(value);
				byte[] array2 = tEcAUWUzShC.YPOqnNyIftMNvsQ(BitConverter.GetBytes((short)num));
				NmaWtEkytZ.Write(array2, 0, array2.Length);
			}
			else
			{
				byte value = 219;
				NmaWtEkytZ.WriteByte(value);
				byte[] array2 = tEcAUWUzShC.YPOqnNyIftMNvsQ(BitConverter.GetBytes(num));
				NmaWtEkytZ.Write(array2, 0, array2.Length);
			}
			NmaWtEkytZ.Write(array, 0, array.Length);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000056CC File Offset: 0x000038CC
		public static void WdFevUgPagpNiHR(Stream LIhotIRYqZMB, byte[] WyTERoMRBzDCpema)
		{
			int num = WyTERoMRBzDCpema.Length;
			if (num <= 255)
			{
				byte value = 196;
				LIhotIRYqZMB.WriteByte(value);
				value = (byte)num;
				LIhotIRYqZMB.WriteByte(value);
			}
			else if (num <= 65535)
			{
				byte value = 197;
				LIhotIRYqZMB.WriteByte(value);
				byte[] array = tEcAUWUzShC.YPOqnNyIftMNvsQ(BitConverter.GetBytes((short)num));
				LIhotIRYqZMB.Write(array, 0, array.Length);
			}
			else
			{
				byte value = 198;
				LIhotIRYqZMB.WriteByte(value);
				byte[] array = tEcAUWUzShC.YPOqnNyIftMNvsQ(BitConverter.GetBytes(num));
				LIhotIRYqZMB.Write(array, 0, array.Length);
			}
			LIhotIRYqZMB.Write(WyTERoMRBzDCpema, 0, WyTERoMRBzDCpema.Length);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000025AB File Offset: 0x000007AB
		public static void BAqGRXuRWmA(Stream DUqCRsTNOvc, double rmBSSPQDfzvBvyq)
		{
			DUqCRsTNOvc.WriteByte(203);
			DUqCRsTNOvc.Write(tEcAUWUzShC.YwcfYDrfpymykcWh(rmBSSPQDfzvBvyq), 0, 8);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000025C6 File Offset: 0x000007C6
		public static void AbNbDbaCRHm(Stream OLBHEXdJgSnxetX, float bwxMWBrVxozx)
		{
			OLBHEXdJgSnxetX.WriteByte(202);
			OLBHEXdJgSnxetX.Write(tEcAUWUzShC.YPOqnNyIftMNvsQ(BitConverter.GetBytes(bwxMWBrVxozx)), 0, 4);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000025E6 File Offset: 0x000007E6
		public static void FnkqkkhIgPrv(Stream PDSdtqtPEKb, bool WtSUORnOHvGF)
		{
			if (WtSUORnOHvGF)
			{
				PDSdtqtPEKb.WriteByte(195);
				return;
			}
			PDSdtqtPEKb.WriteByte(194);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000576C File Offset: 0x0000396C
		public static void qQTxnvrrspEPu(Stream wEmUoJJrrNEDgP, ulong ZnqOjDJlglaI)
		{
			wEmUoJJrrNEDgP.WriteByte(207);
			byte[] bytes = BitConverter.GetBytes(ZnqOjDJlglaI);
			wEmUoJJrrNEDgP.Write(tEcAUWUzShC.YPOqnNyIftMNvsQ(bytes), 0, 8);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000579C File Offset: 0x0000399C
		public static void NoUaVnWJthgnia(Stream TMaPVqdTeRr, long kraKAdeeDXrP)
		{
			if (kraKAdeeDXrP >= 0L)
			{
				if (kraKAdeeDXrP <= 127L)
				{
					TMaPVqdTeRr.WriteByte((byte)kraKAdeeDXrP);
					return;
				}
				if (kraKAdeeDXrP <= 255L)
				{
					TMaPVqdTeRr.WriteByte(204);
					TMaPVqdTeRr.WriteByte((byte)kraKAdeeDXrP);
					return;
				}
				if (kraKAdeeDXrP <= 65535L)
				{
					TMaPVqdTeRr.WriteByte(205);
					TMaPVqdTeRr.Write(tEcAUWUzShC.bHOLARbRaeA((short)kraKAdeeDXrP), 0, 2);
					return;
				}
				if (kraKAdeeDXrP <= 255)
				{
					TMaPVqdTeRr.WriteByte(206);
					TMaPVqdTeRr.Write(tEcAUWUzShC.cuzERRMgbHRIht((int)kraKAdeeDXrP), 0, 4);
					return;
				}
				TMaPVqdTeRr.WriteByte(211);
				TMaPVqdTeRr.Write(tEcAUWUzShC.VeASIKTnGbyBn(kraKAdeeDXrP), 0, 8);
				return;
			}
			else
			{
				if (kraKAdeeDXrP <= -2147483648L)
				{
					TMaPVqdTeRr.WriteByte(211);
					TMaPVqdTeRr.Write(tEcAUWUzShC.VeASIKTnGbyBn(kraKAdeeDXrP), 0, 8);
					return;
				}
				if (kraKAdeeDXrP <= -32768L)
				{
					TMaPVqdTeRr.WriteByte(210);
					TMaPVqdTeRr.Write(tEcAUWUzShC.cuzERRMgbHRIht((int)kraKAdeeDXrP), 0, 4);
					return;
				}
				if (kraKAdeeDXrP <= -128L)
				{
					TMaPVqdTeRr.WriteByte(209);
					TMaPVqdTeRr.Write(tEcAUWUzShC.bHOLARbRaeA((short)kraKAdeeDXrP), 0, 2);
					return;
				}
				if (kraKAdeeDXrP <= -32L)
				{
					TMaPVqdTeRr.WriteByte(208);
					TMaPVqdTeRr.WriteByte((byte)kraKAdeeDXrP);
					return;
				}
				TMaPVqdTeRr.WriteByte((byte)kraKAdeeDXrP);
				return;
			}
		}
	}
}

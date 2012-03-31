using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Codeology.WinAPI
{

    public partial class Kernel
    {

        [DllImport(LIB_NAME,SetLastError = true)]
        public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

        [DllImport(LIB_NAME,SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport(LIB_NAME,SetLastError = true,CharSet = CharSet.Auto)]
        public static extern IntPtr CreateMailslot(string lpName, uint nMaxMessageSize, uint lReadTimeout, IntPtr lpSecurityAttributes);

        [DllImport(LIB_NAME,SetLastError = true)]
        public static extern bool GetMailslotInfo(IntPtr hMailslot, int lpMaxMessageSize, ref uint lpNextSize, ref uint lpMessageCount, IntPtr lpReadTimeout);

        [DllImport(LIB_NAME,SetLastError = true,CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFile(string lpFileName, [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess, [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode, IntPtr lpSecurityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition, [MarshalAs(UnmanagedType.U4)] FileAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, [In] ref NativeOverlapped lpOverlapped);

        [DllImport(LIB_NAME,SetLastError = true)]
        public static extern bool ReadFile(IntPtr hFile, [Out] byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

    }

}

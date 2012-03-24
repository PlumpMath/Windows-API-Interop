using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class User
    {

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern bool GetClassInfoEx(IntPtr hInstance, string lpClassName, ref WNDCLASSEX lpWndClass);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.U2)]
        public static extern short RegisterClassEx([In] ref WNDCLASSEX lpwcx);

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern IntPtr CreateWindowEx(WindowStylesEx dwExStyle, string lpClassName, string lpWindowName, WindowStyles dwStyle,
            int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, WindowProc newProc);

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport(LIB_NAME, SetLastError = true)]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport(LIB_NAME)]
        public static extern bool UnregisterClass(string lpClassName, IntPtr hInstance);

        [DllImport(LIB_NAME, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport(LIB_NAME, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport(LIB_NAME)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport(LIB_NAME)]
        public static extern IntPtr GetClipboardViewer();

        [DllImport(LIB_NAME)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport(LIB_NAME)] 
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport(LIB_NAME)] 
        public static extern bool ShowWindowAsync(IntPtr hWnd,int nCmdShow);

        [DllImport(LIB_NAME)] 
        public static extern bool IsIconic(IntPtr hWnd);

        [DllImport(LIB_NAME)]
        public static extern bool GetLastInputInfo(ref LASTINPUTINFO lii);

    }

}

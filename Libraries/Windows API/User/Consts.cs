using System;
using System.Collections.Generic;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class User
    {

        public const string LIB_NAME = "user32.dll";

        // Window Messages
        public const int WM_CREATE = 0x0001;
        public const int WM_DESTROY = 0x0002;
        public const int WM_CHANGECBCHAIN = 0x030D;
        public const int WM_DRAWCLIPBOARD = 0x0308;

        // GetWindowLong Constants
        public const int GWL_WNDPROC = -4;

        // ShowWindow Constants
        public const int SW_RESTORE = 9;

    }

}

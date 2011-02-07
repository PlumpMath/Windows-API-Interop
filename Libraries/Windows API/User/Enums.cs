using System;
using System.Collections.Generic;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class User
    {

        [Flags]     
        public enum ClassStyles : uint
        {
            None = 0
        }

        [Flags]     
        public enum WindowStylesEx : uint 
        {
            WS_EX_TOOLWINDOW = 0x00000080
        }

        [Flags]
        public enum WindowStyles : uint
        {
            WS_POPUP = 0x80000000u
        }

    }

}

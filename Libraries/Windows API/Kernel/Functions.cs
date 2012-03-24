using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class Kernel
    {

        [DllImport(LIB_NAME)]
        public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

    }

}

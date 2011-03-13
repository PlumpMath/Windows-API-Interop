using System;
using System.Collections.Generic;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class WLAN
    {

       public delegate void WlanNotificationCallbackDelegate(ref WlanNotificationData notificationData, IntPtr context);

    }

}

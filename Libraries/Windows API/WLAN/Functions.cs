using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class WLAN
    {

        [DebuggerStepThrough]
        public static void ThrowIfError(int errorCode)
        {
            if (errorCode != 0) {
                throw new Win32Exception(errorCode);
            }
        }

        [DebuggerStepThrough]
        public static bool AssertError(int errorCode)
        {
            return (errorCode != 0);
        }

        [DllImport(LIB_NAME)]
        public static extern int WlanCloseHandle([In] IntPtr clientHandle, [In, Out] IntPtr pReserved);

        [DllImport(LIB_NAME)]
        public static extern int WlanConnect([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] ref WlanConnectionParameters connectionParameters, IntPtr pReserved);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanDeleteProfile([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In, MarshalAs(UnmanagedType.LPWStr)] string profileName, IntPtr reservedPtr);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanEnumInterfaces([In] IntPtr clientHandle, [In, Out] IntPtr pReserved, out IntPtr ppInterfaceList);
        
        [DllImport(LIB_NAME)]
        public static extern void WlanFreeMemory(IntPtr pMemory);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanGetAvailableNetworkList([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] WlanGetAvailableNetworkFlags flags, [In, Out] IntPtr reservedPtr, out IntPtr availableNetworkListPtr);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanGetNetworkBssList([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] IntPtr dot11SsidInt, [In] Dot11BssType dot11BssType, [In] bool securityEnabled, IntPtr reservedPtr, out IntPtr wlanBssList);
        
        //[DllImport(LIB_NAME)]
        //public static extern int WlanGetNetworkBssList([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] WLAN.Dot11Ssid dot11Ssid, [In] Dot11BssType dot11BssType, [In] bool securityEnabled, IntPtr reservedPtr, out IntPtr wlanBssList);

        [DllImport(LIB_NAME)]
        public static extern int WlanGetProfile([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In, MarshalAs(UnmanagedType.LPWStr)] string profileName, [In] IntPtr pReserved, out IntPtr profileXml, [Optional] out WlanProfileFlags flags, [Optional] out WlanAccess grantedAccess);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanGetProfileList([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] IntPtr pReserved, out IntPtr profileList);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanOpenHandle([In] uint clientVersion, [In, Out] IntPtr pReserved, out uint negotiatedVersion, out IntPtr clientHandle);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanQueryInterface([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] WlanIntfOpcode opCode, [In, Out] IntPtr pReserved, out int dataSize, out IntPtr ppData, out WlanOpcodeValueType wlanOpcodeValueType);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanReasonCodeToString([In] WlanReasonCode reasonCode, [In] int bufferSize, [In, Out] StringBuilder stringBuffer, IntPtr pReserved);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanRegisterNotification([In] IntPtr clientHandle, [In] WlanNotificationSource notifSource, [In] bool ignoreDuplicate, [In] WlanNotificationCallbackDelegate funcCallback, [In] IntPtr callbackContext, [In] IntPtr reserved, out WlanNotificationSource prevNotifSource);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanScan([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] IntPtr pDot11Ssid, [In] IntPtr pIeData, [In, Out] IntPtr pReserved);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanSetInterface([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] WlanIntfOpcode opCode, [In] uint dataSize, [In] IntPtr pData, [In, Out] IntPtr pReserved);
        
        [DllImport(LIB_NAME)]
        public static extern int WlanSetProfile([In] IntPtr clientHandle, [In, MarshalAs(UnmanagedType.LPStruct)] Guid interfaceGuid, [In] WlanProfileFlags flags, [In, MarshalAs(UnmanagedType.LPWStr)] string profileXml, [In, Optional, MarshalAs(UnmanagedType.LPWStr)] string allUserProfileSecurity, [In] bool overwrite, [In] IntPtr pReserved, out WlanReasonCode reasonCode);

    }

}

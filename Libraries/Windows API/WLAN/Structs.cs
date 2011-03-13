using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class WLAN
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct Dot11Ssid
        {
            public readonly uint SSIDLength;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x20)]
            public readonly byte[] SSID;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WlanAssociationAttributes
        {
            private readonly Dot11Ssid dot11Ssid;
            private readonly Dot11BssType dot11BssType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)] private readonly byte[] dot11Bssid;
            private readonly Dot11PhyType dot11PhyType;
            private readonly uint dot11PhyIndex;
            private readonly uint wlanSignalQuality;
            private readonly uint rxRate;
            private readonly uint txRate;
            public PhysicalAddress Dot11Bssid
            {
                get
                {
                    return dot11Bssid != null
                               ? new PhysicalAddress(dot11Bssid)
                               : new PhysicalAddress(new byte[] {0, 0, 0, 0, 0, 0});
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
        public struct WlanAvailableNetwork
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x100)] private readonly string profileName;
            public Dot11Ssid dot11Ssid;
            private readonly Dot11BssType dot11BssType;
            private readonly uint numberOfBssids;
            private readonly bool networkConnectable;
            private readonly WlanReasonCode wlanNotConnectableReason;
            private readonly uint numberOfPhyTypes;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
            private readonly Dot11PhyType[] dot11PhyTypes;

            private readonly bool morePhyTypes;
            public readonly uint wlanSignalQuality;
            private readonly bool securityEnabled;
            public readonly Dot11AuthAlgorithm dot11DefaultAuthAlgorithm;
            public readonly Dot11CipherAlgorithm dot11DefaultCipherAlgorithm;
            private readonly WlanAvailableNetworkFlags flags;
            private readonly uint reserved;
            public Dot11PhyType[] Dot11PhyTypes
            {
                get
                {
                    Dot11PhyType[] destinationArray = new Dot11PhyType[numberOfPhyTypes];
                    Array.Copy(dot11PhyTypes, destinationArray, numberOfPhyTypes);
                    return destinationArray;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WlanAvailableNetworkListHeader
        {
            public readonly uint numberOfItems;
            private uint index;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WlanBssEntry
        {
            public Dot11Ssid dot11Ssid;
            private readonly uint phyId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
            public readonly byte[] dot11Bssid;
            public readonly Dot11BssType dot11BssType;
            public readonly Dot11PhyType dot11BssPhyType;
            public readonly int rssi;
            public readonly uint linkQuality;
            private readonly bool inRegDomain;
            private readonly ushort beaconPeriod;
            private readonly ulong timestamp;
            private readonly ulong hostTimestamp;
            private readonly ushort capabilityInformation;
            public readonly uint chCenterFrequency;
            public WlanRateSet wlanRateSet;
            public readonly uint ieOffset;
            public readonly uint ieSize;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct WlanBssListHeader
        {
            private readonly uint totalSize;
            public readonly uint numberOfItems;
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
        public struct WlanConnectionAttributes
        {
            public readonly WlanInterfaceState isState;
            public readonly WlanConnectionMode wlanConnectionMode;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x100)] private readonly string profileName;
            public readonly WlanAssociationAttributes wlanAssociationAttributes;
            private readonly WlanSecurityAttributes wlanSecurityAttributes;
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
        public struct WlanConnectionNotificationData
        {
            private readonly WlanConnectionMode wlanConnectionMode;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x20)]
            public readonly string profileName;

            private readonly Dot11Ssid dot11Ssid;
            private readonly Dot11BssType dot11BssType;
            private readonly bool securityEnabled;
            public readonly WlanReasonCode wlanReasonCode;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=1)]
            public string profileXml;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WlanConnectionParameters
        {
            public WlanConnectionMode wlanConnectionMode;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string profile;
            public IntPtr dot11SsidPtr;
            private IntPtr desiredBssidListPtr;
            public Dot11BssType dot11BssType;
            public WlanConnectionFlags flags;
        }


        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
        public struct WlanInterfaceInfo
        {
            public Guid interfaceGuid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x100)]
            public readonly string interfaceDescription;

            private readonly WlanInterfaceState isState;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WlanInterfaceInfoListHeader
        {
            public readonly uint numberOfItems;
            private readonly uint index;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct WlanNotificationData
        {

            public readonly WlanNotificationSource notificationSource;
            public readonly int notificationCode;
            public Guid interfaceGuid;
            public readonly int dataSize;
            public IntPtr dataPtr;
            public object NotificationCode
            {
                get
                {
                    if (notificationSource == WlanNotificationSource.Msm)
                    {
                        return (WlanNotificationCodeMsm) notificationCode;
                    }
                    if (notificationSource == WlanNotificationSource.Acm)
                    {
                        return (WlanNotificationCodeAcm) notificationCode;
                    }
                    return notificationCode;
                }
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
        public struct WlanProfileInfo
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x100)] private readonly string profileName;
            private readonly WlanProfileFlags profileFlags;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WlanProfileInfoListHeader
        {
            public readonly uint numberOfItems;
            private readonly uint index;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WlanRateSet
        {
            private readonly uint rateSetLength;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst=0x7e)]
            private readonly ushort[] rateSet;
            public ushort[] Rates
            {
                get
                {
                    ushort[] destinationArray = new ushort[rateSetLength];
                    Array.Copy(rateSet, destinationArray, destinationArray.Length);
                    return destinationArray;
                }
            }
            public double GetRateInMbps(int rate)
            {
                return ((rateSet[rate] & 0x7fff) * 0.5);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WlanSecurityAttributes
        {
            [MarshalAs(UnmanagedType.Bool)] private readonly bool securityEnabled;
            [MarshalAs(UnmanagedType.Bool)] private readonly bool oneXEnabled;
            private readonly Dot11AuthAlgorithm dot11AuthAlgorithm;
            private readonly Dot11CipherAlgorithm dot11CipherAlgorithm;
        }

    }

}

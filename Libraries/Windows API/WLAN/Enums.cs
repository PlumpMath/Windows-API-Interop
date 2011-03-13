using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Codeology.WinAPI
{

    public partial class WLAN
    {

        public enum Dot11AuthAlgorithm : uint
        {
            IEEE80211_Open = 1,
            IEEE80211_SharedKey = 2,
            IHV_End = 0xffffffff,
            IHV_Start = 0x80000000,
            RSNA = 6,
            RSNA_PSK = 7,
            WPA = 3,
            WPA_None = 5,
            WPA_PSK = 4
        }

        public enum Dot11BssType
        {
            Any = 3,
            Independent = 2,
            Infrastructure = 1
        }

        public enum Dot11CipherAlgorithm : uint
        {
            CCMP = 4,
            IHV_End = 0xffffffff,
            IHV_Start = 0x80000000,
            None = 0,
            RSN_UseGroup = 0x100,
            TKIP = 2,
            WEP = 0x101,
            WEP104 = 5,
            WEP40 = 1,
            WPA_UseGroup = 0x100
        }

        [Flags]
        public enum Dot11OperationMode : uint
        {
            Ap = 2,
            ExtensibleStation = 4,
            NetworkMonitor = 0x80000000,
            Station = 1,
            Unknown = 0
        }

        public enum Dot11PhyType : uint
        {
            Any = 0,
            Dsss = 2,
            Erp = 6,
            Fhss = 1,
            Hrdsss = 5,
            Ht = 7,
            IhvEnd = 0xffffffff,
            IhvStart = 0x80000000,
            IrBaseband = 3,
            Ofdm = 4,
            Unknown = 0
        }

        [Flags]
        public enum WlanAccess
        {
            ExecuteAccess = 0x20021,
            ReadAccess = 0x20001,
            WriteAccess = 0x70023
        }

        public enum WlanAdhocNetworkState
        {
            Formed,
            Connected
        }

        [Flags]
        private enum WlanAvailableNetworkFlags
        {
            Connected = 1,
            HasProfile = 2
        }

        [Flags]
        public enum WlanConnectionFlags
        {
            AdhocJoinOnly = 2,
            EapolPassthrough = 8,
            HiddenNetwork = 1,
            IgnorePrivacyBit = 4
        }

        public enum WlanConnectionMode
        {
            Profile,
            TemporaryProfile,
            DiscoverySecure,
            DiscoveryUnsecure,
            Auto,
            Invalid
        }

        [Flags]
        public enum WlanGetAvailableNetworkFlags
        {
            IncludeAllAdhocProfiles = 1,
            IncludeAllManualHiddenProfiles = 2
        }

        public enum WlanInterfaceState
        {
            NotReady,
            Connected,
            AdHocNetworkFormed,
            Disconnecting,
            Disconnected,
            Associating,
            Discovering,
            Authenticating
        }

        public enum WlanIntfOpcode
        {
            AutoconfEnabled = 1,
            BackgroundScanEnabled = 2,
            BssType = 5,
            ChannelNumber = 8,
            CurrentConnection = 7,
            CurrentOperationMode = 12,
            IhvEnd = 0x3fffffff,
            IhvStart = 0x30000000,
            InterfaceState = 6,
            MediaStreamingMode = 3,
            RadioState = 4,
            Rssi = 0x10000102,
            SecurityEnd = 0x2fffffff,
            SecurityStart = 0x20010000,
            Statistics = 0x10000101,
            SupportedAdhocAuthCipherPairs = 10,
            SupportedCountryOrRegionStringList = 11,
            SupportedInfrastructureAuthCipherPairs = 9
        }

        public enum WlanNotificationCodeAcm
        {
            AdhocNetworkStateChange = 0x16,
            AutoconfDisabled = 2,
            AutoconfEnabled = 1,
            BackgroundScanDisabled = 4,
            BackgroundScanEnabled = 3,
            BssTypeChange = 5,
            ConnectionAttemptFail = 11,
            ConnectionComplete = 10,
            ConnectionStart = 9,
            Disconnected = 0x15,
            Disconnecting = 20,
            FilterListChange = 12,
            InterfaceArrival = 13,
            InterfaceRemoval = 14,
            NetworkAvailable = 0x13,
            NetworkNotAvailable = 0x12,
            PowerSettingChange = 6,
            ProfileChange = 15,
            ProfileNameChange = 0x10,
            ProfilesExhausted = 0x11,
            ScanComplete = 7,
            ScanFail = 8
        }

        public enum WlanNotificationCodeMsm
        {
            AdapterOperationModeChange = 14,
            AdapterRemoval = 13,
            Associated = 2,
            Associating = 1,
            Authenticating = 3,
            Connected = 4,
            Disassociating = 9,
            Disconnected = 10,
            PeerJoin = 11,
            PeerLeave = 12,
            RadioStateChange = 7,
            RoamingEnd = 6,
            RoamingStart = 5,
            SignalQualityChange = 8
        }

        [Flags]
        public enum WlanNotificationSource
        {
            Acm = 8,
            All = 0xffff,
            Ihv = 0x40,
            Msm = 0x10,
            None = 0,
            Security = 0x20
        }

        public enum WlanOpcodeValueType
        {
            QueryOnly,
            SetByGroupPolicy,
            SetByUser,
            Invalid
        }

        [Flags]
        public enum WlanProfileFlags
        {
            AllUser,
            GroupPolicy,
            User
        }

        public enum WlanReasonCode
        {
            AcBase = 0x20000,
            AcConnectBase = 0x28000,
            AcEnd = 0x2ffff,
            AdhocSecurityFailure = 0x3800a,
            AssociationFailure = 0x38002,
            AssociationTimeout = 0x38003,
            AutoSwitchSetForAdhoc = 0x80010,
            AutoSwitchSetForManualConnection = 0x80011,
            Base = 0x20000,
            BssTypeNotAllowed = 0x28005,
            BssTypeUnmatch = 0x30003,
            ConflictSecurity = 0x8000b,
            ConnectCallFail = 0x28009,
            DatarateUnmatch = 0x30005,
            DisconnectTimeout = 0x3800f,
            DriverDisconnected = 0x3800b,
            DriverOperationFailure = 0x3800c,
            GpDenied = 0x28003,
            IhvNotAvailable = 0x3800d,
            IhvNotResponding = 0x3800e,
            IhvOuiMismatch = 0x80008,
            IhvOuiMissing = 0x80009,
            IhvSecurityNotSupported = 0x80007,
            IhvSecurityOnexMissing = 0x80012,
            IhvSettingsMissing = 0x8000a,
            InBlockedList = 0x28007,
            InFailedList = 0x28006,
            InternalFailure = 0x38010,
            InvalidAdhocConnectionMode = 0x8000e,
            InvalidBssType = 0x8000d,
            InvalidPhyType = 0x80005,
            InvalidProfileName = 0x80003,
            InvalidProfileSchema = 0x80001,
            InvalidProfileType = 0x80004,
            KeyMismatch = 0x2800d,
            MsmBase = 0x30000,
            MsmConnectBase = 0x38000,
            MsmEnd = 0x3ffff,
            MsmSecurityMissing = 0x80006,
            MsmsecAuthStartTimeout = 0x48002,
            MsmsecAuthSuccessTimeout = 0x48003,
            MsmsecBase = 0x40000,
            MsmsecCancelled = 0x48011,
            MsmsecCapabilityDiscovery = 0x40015,
            MsmsecCapabilityNetwork = 0x40012,
            MsmsecCapabilityNic = 0x40013,
            MsmsecCapabilityProfile = 0x40014,
            MsmsecCapabilityProfileAuth = 0x4001e,
            MsmsecCapabilityProfileCipher = 0x4001f,
            MsmsecConnectBase = 0x48000,
            MsmsecDowngradeDetected = 0x48013,
            MsmsecEnd = 0x4ffff,
            MsmsecForcedFailure = 0x48015,
            MsmsecG1MissingGrpKey = 0x4800d,
            MsmsecG1MissingKeyData = 0x4800c,
            MsmsecKeyFormat = 0x48012,
            MsmsecKeyStartTimeout = 0x48004,
            MsmsecKeySuccessTimeout = 0x48005,
            MsmsecM3MissingGrpKey = 0x48008,
            MsmsecM3MissingIe = 0x48007,
            MsmsecM3MissingKeyData = 0x48006,
            MsmsecMax = 0x4ffff,
            MsmsecMin = 0x40000,
            MsmsecMixedCell = 0x40019,
            MsmsecNicFailure = 0x48010,
            MsmsecNoAuthenticator = 0x4800f,
            MsmsecNoPairwiseKey = 0x4800b,
            MsmsecPeerIndicatedInsecure = 0x4800e,
            MsmsecPrIeMatching = 0x48009,
            MsmsecProfileAuthTimersInvalid = 0x4001a,
            MsmsecProfileDuplicateAuthCipher = 0x40007,
            MsmsecProfileInvalidAuthCipher = 0x40009,
            MsmsecProfileInvalidGkeyIntv = 0x4001b,
            MsmsecProfileInvalidKeyIndex = 0x40001,
            MsmsecProfileInvalidPmkcacheMode = 0x4000c,
            MsmsecProfileInvalidPmkcacheSize = 0x4000d,
            MsmsecProfileInvalidPmkcacheTtl = 0x4000e,
            MsmsecProfileInvalidPreauthMode = 0x4000f,
            MsmsecProfileInvalidPreauthThrottle = 0x40010,
            MsmsecProfileKeyLength = 0x40003,
            MsmsecProfileKeyUnmappedChar = 0x4001d,
            MsmsecProfileKeymaterialChar = 0x40017,
            MsmsecProfileNoAuthCipherSpecified = 0x40005,
            MsmsecProfileOnexDisabled = 0x4000a,
            MsmsecProfileOnexEnabled = 0x4000b,
            MsmsecProfilePassphraseChar = 0x40016,
            MsmsecProfilePreauthOnlyEnabled = 0x40011,
            MsmsecProfilePskLength = 0x40004,
            MsmsecProfilePskPresent = 0x40002,
            MsmsecProfileRawdataInvalid = 0x40008,
            MsmsecProfileTooManyAuthCipherSpecified = 0x40006,
            MsmsecProfileWrongKeytype = 0x40018,
            MsmsecPskMismatchSuspected = 0x48014,
            MsmsecSecIeMatching = 0x4800a,
            MsmsecSecurityUiFailure = 0x48016,
            MsmsecTransitionNetwork = 0x4001c,
            MsmsecUiRequestFailure = 0x48001,
            NetworkNotAvailable = 0x2800b,
            NetworkNotCompatible = 0x20001,
            NoAutoConnection = 0x28001,
            NonBroadcastSetForAdhoc = 0x8000f,
            NotVisible = 0x28002,
            PhyTypeUnmatch = 0x30004,
            PreSecurityFailure = 0x38004,
            ProfileBase = 0x80000,
            ProfileChangedOrDeleted = 0x2800c,
            ProfileConnectBase = 0x88000,
            ProfileEnd = 0x8ffff,
            ProfileMissing = 0x80002,
            ProfileNotCompatible = 0x20002,
            ProfileSsidInvalid = 0x80013,
            RangeSize = 0x10000,
            RoamingFailure = 0x38008,
            RoamingSecurityFailure = 0x38009,
            ScanCallFail = 0x2800a,
            SecurityFailure = 0x38006,
            SecurityMissing = 0x8000c,
            SecurityTimeout = 0x38007,
            SsidListTooLong = 0x28008,
            StartSecurityFailure = 0x38005,
            Success = 0,
            TooManySecurityAttempts = 0x38012,
            TooManySsid = 0x80014,
            UiRequestTimeout = 0x38011,
            Unknown = 0x10001,
            UnsupportedSecuritySet = 0x30002,
            UnsupportedSecuritySetByOs = 0x30001,
            UserCancelled = 0x38001,
            UserDenied = 0x28004,
            UserNotRespond = 0x2800e
        }

    }

}

#if USE_ANDROID_DEVICE_CORE

namespace YVR.Enterprise.Device
{
    public class SystemConfigurationElements : Elements
    {
        public const string setScreenOffTimeOut = "setScreenOffTimeOut";
        public const string getScreenOffTimeOut = "getScreenOffTimeOut";
        public const string setScreenOffSleepTimeOut = "setScreenOffSleepTimeOut";
        public const string getScreenOffSleepTimeOut = "getScreenOffSleepTimeOut";
        public const string getBrightness = "getBrightness";
        public const string setBrightness = "setBrightness";
        public const string getVolume = "getSystemAudioVolume";
        public const string setVolume = "setSystemAudioVolume";
        public const string getMaxVolume = "getSystemMaxAudioVolume";
        public const string setEyeProtectionMode = "setEyeProtectionMode";
        public const string getEyeProtectionMode = "getEyeProtectionMode";
        public const string setHandTrackingStatus = "setHandTrackingStatus";
        public const string getHandTrackingStatus = "getHandTrackingStatus";
        public const string changeThirdHomeState = "changeThirdHomeState";
        public const string setYvrLauncherState = "setYvrLauncherState";
        public const string getYvrLauncherState = "getYvrLauncherState";
        public const string setPassthroughVisibility = "setPassthroughVisibility";
        public const string isPassthroughVisibility = "isPassthroughVisibility";
        public const string connectWifiAp = "connectWifiAp";
        public const string getWifiNameConnected = "getWifiNameConnected";
        public const string getWifiIP = "getWifiIP";
        public const string getSecurityAreaStatus = "getSecurityAreaStatus";
        public const string setSecurityAreaStatus = "setSecurityAreaStatus";
        public const string setSecurityTracking = "setSecurityTracking";
        public const string getSecurityTracking = "getSecurityTracking";
        public const string setUsbDebugMode = "setUsbDebugMode";
        public const string getUsbDebugMode = "getUsbDebugMode";
        public const string setBtEnabled = "setBtEnabled";
        public const string createSecurityArea = "createSecurityArea";
        public const string setShowGestureCtrlHomeIcon = "setShowGestureCtrlHomeIcon";
        public const string isShowGestureCtrlHomeIcon = "isShowGestureCtrlHomeIcon";

        public const string restrictVolumeAdjustment = "restrictVolumeAdjustment";
        public const string isVolumeAdjustmentRestricted = "isVolumeAdjustmentRestricted";

        public const string restrictBrightnessAdjustment = "restrictBrightnessAdjustment";
        public const string isBrightnessAdjustmentRestricted = "isBrightnessAdjustmentRestricted";

        public const string setIPDManualAdjustmentState = "setIpdManualAdjustmentState";
        public const string getIpdManualAdjustmentState = "isIpdManualAdjustmentEnable";

        public const string setRecenterEnable = "switchRecenter";
        public const string getRecenterEnable = "isRecenterOpen";
        public const string setUsingRightControllerForRecenter = "setRecenterController";
        public const string getUsingRightControllerForRecenter = "isUsingRightStickForRecenter";

        public const string setSystemSettingsInt = "putIntForSettingsSystem";
        public const string getSystemSettingsInt = "getIntForSettingsSystem";

        public const string setBizCustomKeyFeature = "setBizCustomKeyFeature";
    }
}
#endif
using System;
using UnityEngine;
using YVR.AndroidDevice.Core.Utilities;

#if USE_ANDROID_DEVICE_CORE

namespace YVR.Enterprise.Device
{
    public class SystemConfigurationMgr : BaseMgr<SystemConfigurationMgr, SystemConfigurationElements>
    {
        public int screenOffTimeOut
        {
            get => ajcBase.CallJNI<int>(SystemConfigurationElements.getScreenOffTimeOut);
            set => ajcBase.CallJNI(SystemConfigurationElements.setScreenOffTimeOut, value);
        }

        public int screenOffSleepTimeOut
        {
            get => ajcBase.CallJNI<int>(SystemConfigurationElements.getScreenOffSleepTimeOut);
            set => ajcBase.CallJNI<bool>(SystemConfigurationElements.setScreenOffSleepTimeOut, value);
        }

        public int brightness
        {
            get => ajcBase.CallJNI<int>(SystemConfigurationElements.getBrightness);
            set => ajcBase.CallJNI(SystemConfigurationElements.setBrightness, value);
        }

        public int volume
        {
            get => ajcBase.CallJNI<int>(SystemConfigurationElements.getVolume);
            set => ajcBase.CallJNI(SystemConfigurationElements.setVolume, value);
        }

        public int maxVolume => ajcBase.CallJNI<int>(SystemConfigurationElements.getMaxVolume);

        public bool eyeProtectionMode
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.getEyeProtectionMode);
            set => ajcBase.CallJNI(SystemConfigurationElements.setEyeProtectionMode, value);
        }

        public bool handTrackingStatus
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.getHandTrackingStatus);
            set => ajcBase.CallJNI(SystemConfigurationElements.setHandTrackingStatus, value);
        }

        public bool ChangeThirdHomeState(string packageName, bool isEnable)
        {
            return ajcBase.CallJNI<bool>(SystemConfigurationElements.changeThirdHomeState, packageName, isEnable);
        }

        public bool yvrLauncherState
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.getYvrLauncherState);
            set => ajcBase.CallJNI(SystemConfigurationElements.setYvrLauncherState, value);
        }

        public void SetRecenterEnable(bool open)
        {
            ajcBase.CallJNI(SystemConfigurationElements.setRecenterEnable, open);
        }

        public bool isRecenterEnable => ajcBase.CallJNI<bool>(SystemConfigurationElements.getRecenterEnable);

        public void SetUsingRightControllerForRecenter(bool useRightController)
        {
            ajcBase.CallJNI(SystemConfigurationElements.setUsingRightControllerForRecenter, useRightController);
        }

        public bool isUsingRightControllerForRecenter =>
            ajcBase.CallJNI<bool>(SystemConfigurationElements.getUsingRightControllerForRecenter);

        public bool passthroughVisibility
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.isPassthroughVisibility);
            set => ajcBase.CallJNI(SystemConfigurationElements.setPassthroughVisibility, value);
        }

        public bool ConnectWifiAp(string ssid, string pwd, Action<string> callback = null)
        {
            return ajcBase.CallJNI<bool>(SystemConfigurationElements.connectWifiAp, ssid, pwd,
                                         JavaObjectConverter.CreatConsumerProxy(callback));
        }

        public string GetWifiNameConnected(Action<string> callback = null)
        {
            return ajcBase.CallJNI<string>(SystemConfigurationElements.getWifiNameConnected,
                                           JavaObjectConverter.CreatConsumerProxy(callback));
        }

        public string GetWifiIP(Action<string> callback = null)
        {
            return ajcBase.CallJNI<string>(SystemConfigurationElements.getWifiIP,
                                           JavaObjectConverter.CreatConsumerProxy(callback));
        }

        public int securityAreaStatus
        {
            get => ajcBase.CallJNI<int>(SystemConfigurationElements.getSecurityAreaStatus);
            set => ajcBase.CallJNI(SystemConfigurationElements.setSecurityAreaStatus, value);
        }

        public int securityTracking
        {
            get => ajcBase.CallJNI<int>(SystemConfigurationElements.getSecurityTracking);
            set => ajcBase.CallJNI(SystemConfigurationElements.setSecurityTracking, value);
        }

        public bool usbDebugMode
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.getUsbDebugMode);
            set => ajcBase.CallJNI(SystemConfigurationElements.setUsbDebugMode, value);
        }

        public void SetBtEnabled(bool enabled) { ajcBase.CallJNI(SystemConfigurationElements.setBtEnabled, enabled); }

        public void CreateSecurityArea() { ajcBase.CallJNI(SystemConfigurationElements.createSecurityArea); }

        public bool isShowGestureCtrlHomeIcon
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.isShowGestureCtrlHomeIcon);
            set => ajcBase.CallJNI(SystemConfigurationElements.setShowGestureCtrlHomeIcon, value);
        }

        public bool brightnessAdjustmentRestricted
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.isBrightnessAdjustmentRestricted);
            set => ajcBase.CallJNI(SystemConfigurationElements.restrictBrightnessAdjustment, value);
        }

        public bool volumeAdjustmentRestricted
        {
            get => ajcBase.CallJNI<bool>(SystemConfigurationElements.isVolumeAdjustmentRestricted);
            set => ajcBase.CallJNI(SystemConfigurationElements.restrictVolumeAdjustment, value);
        }

        public void EnableIPDAutoAdjustment(bool enable) { CorePlugin.Instance.SetIPDEnable(enable); }

        public bool GetIPDAutoAdjustmentEnable() { return CorePlugin.Instance.GetIPDEnable(); }

        public void EnableIPDManualAdjustment(bool enable)
        {
            ajcBase.CallJNI(SystemConfigurationElements.setIPDManualAdjustmentState, enable);
        }

        public bool GetIPDManualAdjustmentEnable()
        {
            return ajcBase.CallJNI<bool>(SystemConfigurationElements.getIpdManualAdjustmentState);
        }

        public void SetIPDValue(float value) { CorePlugin.Instance.SetIPDValue(value); }

        public float GetIPDValue() { return CorePlugin.Instance.GetIPDVale(); }

        public bool IsETFREnable()
        {
            int value = ajcBase.CallJNI<int>(SystemConfigurationElements.getSystemSettingsInt, "xr_etfr_render_focus");
            return value == 1;
        }

        public bool IsETFRScreenEnable()
        {
            int value = ajcBase.CallJNI<int>(SystemConfigurationElements.getSystemSettingsInt,
                                             "xr_etfr_screen_enabled");
            return value == 1;
        }

        public void SetScreenETFRModeEnable(bool enable)
        {
            ajcBase.CallJNI<bool>(SystemConfigurationElements.setSystemSettingsInt, "xr_etfr_screen_enabled",
                                  enable ? 1 : 0);
        }

        public void SetETFREnable(bool enable)
        {
            ajcBase.CallJNI<bool>(SystemConfigurationElements.setSystemSettingsInt, "xr_etfr_render_focus",
                                  enable ? 1 : 0);
        }

        public bool Is4KRenderingMode()
        {
            int _4kMode = ajcBase.CallJNI<int>(SystemConfigurationElements.getSystemSettingsInt, "xr_display_4k_mode");

            return _4kMode == 1;
        }

        public void Set4KRenderingMode(bool enable)
        {
            ajcBase.CallJNI<bool>(SystemConfigurationElements.setSystemSettingsInt, "xr_display_4k_mode",
                                  enable ? 1 : 0);
        }

        public void SetPowerTripleClickEnable(bool enable)
        {
            var value = enable ? "eye_calibration" : "disable";
            ajcBase.CallJNI<bool>(SystemConfigurationElements.setBizCustomKeyFeature, "power_triple_click",value);
        }

        public void SetPowerKnobClickEnable(bool enable)
        {
            var value = enable ? "screencap" : "disable";
            ajcBase.CallJNI<bool>(SystemConfigurationElements.setBizCustomKeyFeature, "power_knob_click",value);
        }

        public void ApplyUserConfig(string json, Action<string> callback)
        {
            ajcBase.CallJNI<bool>(SystemConfigurationElements.applyUserConfig, json,
                JavaObjectConverter.CreatConsumerProxy(callback));
        }
    }
}
#endif
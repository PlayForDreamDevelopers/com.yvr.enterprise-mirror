using System;
using YVR.AndroidDevice.Core.Utilities;

namespace YVR.Enterprise.Device
{
    public class ScreenRecordingMgr:BaseMgr<ScreenRecordingMgr,ScreenRecordingElements>
    {
        public void StartRecordScreen()
        {
            ajcBase.CallJNI(ScreenRecordingElements.startRecordScreen);
        }

        public void StopRecordScreen()
        {
            ajcBase.CallJNI(ScreenRecordingElements.stopRecordScreen);
        }

        public void ScreenShot(Action<string> callback = null)
        {
            ajcBase.CallJNI(ScreenRecordingElements.screenShot, JavaObjectConverter.CreatConsumerProxy(callback));
        }
    }
}

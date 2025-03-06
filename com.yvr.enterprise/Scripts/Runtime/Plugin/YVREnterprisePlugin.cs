using System.Runtime.InteropServices;

namespace YVR.Enterprise
{
    public static class YVREnterprisePlugin
    {
        [DllImport("enterprisePlugin")]
        private static extern void YVRSetVSTCameraFrequency(VSTCameraFrequencyType freq);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGetVSTCameraFrequency(ref VSTCameraFrequencyType freq);

        [DllImport("enterprisePlugin")]
        private static extern void YVRSetVSTCameraResolution(VSTCameraResolutionType resolution);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGetVSTCameraResolution(ref VSTCameraResolutionType resolution);

        [DllImport("enterprisePlugin")]
        private static extern void YVRSetVSTCameraFormat(VSTCameraFormatType formatType);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGetVSTCameraFormat(ref VSTCameraFormatType formatType);

        [DllImport("enterprisePlugin")]
        private static extern void YVRSetVSTCameraOutputSource(VSTCameraSourceType sourceType);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGetVSTCameraOutputSource(ref VSTCameraSourceType sourceType);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGetVSTCameraIntrinsicExtrinsic(YVREyeNumberType eyeNumberType, ref VSTCameraIntrinsicExtrinsicData data);

        [DllImport("enterprisePlugin")]
        private static extern void YVROpenVSTCamera();

        [DllImport("enterprisePlugin")]
        private static extern void YVRCloseVSTCamera();

        [DllImport("enterprisePlugin")]
        private static extern void YVRAcquireVSTCameraFrame(ref VSTCameraFrameData frameData);

        public static void SetVSTCameraFrequency(VSTCameraFrequencyType freq)
        {
            YVRSetVSTCameraFrequency(freq);
        }

        public static void GetVSTCameraFrequency(ref VSTCameraFrequencyType freq)
        {
            YVRGetVSTCameraFrequency(ref freq);
        }

        public static void SetVSTCameraResolution(VSTCameraResolutionType resolution)
        {
            YVRSetVSTCameraResolution(resolution);
        }

        public static void GetVSTCameraResolution(ref VSTCameraResolutionType resolution)
        {
            YVRGetVSTCameraResolution(ref resolution);
        }

        public static void SetVSTCameraFormat(VSTCameraFormatType formatType)
        {
            YVRSetVSTCameraFormat(formatType);
        }

        public static void GetVSTCameraFormat(ref VSTCameraFormatType formatType)
        {
            YVRGetVSTCameraFormat(ref formatType);
        }

        public static void SetVSTCameraOutputSource(VSTCameraSourceType sourceType)
        {
            YVRSetVSTCameraOutputSource(sourceType);
        }

        public static void GetVSTCameraOutputSource(ref VSTCameraSourceType sourceType)
        {
            YVRGetVSTCameraOutputSource(ref sourceType);
        }

        public static void GetVSTCameraIntrinsicExtrinsic(YVREyeNumberType eyeNumberType,ref VSTCameraIntrinsicExtrinsicData data)
        {
            YVRGetVSTCameraIntrinsicExtrinsic(eyeNumberType,ref data);
        }

        public static void OpenVSTCamera()
        {
            YVROpenVSTCamera();
        }

        public static void CloseVSTCamera()
        {
            YVRCloseVSTCamera();
        }

        public static void AcquireVSTCameraFrame(ref VSTCameraFrameData frameData)
        {
            YVRAcquireVSTCameraFrame(ref frameData);
        }
    }
}
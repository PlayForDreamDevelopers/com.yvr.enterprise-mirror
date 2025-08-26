using System;
using System.Runtime.InteropServices;
using YVR.Enterprise.Render;

namespace YVR.Enterprise.Camera
{
    public static class YVRVSTCameraPlugin
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
        private static extern void YVRGetVSTCameraIntrinsicExtrinsic(VSTCameraSourceType eyeNumberType,
                                                                     ref VSTCameraIntrinsicExtrinsicData data);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGetVSTCameraIntrinsicExtrinsicRelativeToIMU(VSTCameraSourceType eyeNumberType,
            ref VSTCameraIntrinsicExtrinsicData data);

        [DllImport("enterprisePlugin")]
        private static extern void YVROpenVSTCamera();

        [DllImport("enterprisePlugin")]
        private static extern void YVRCloseVSTCamera();

        [DllImport("enterprisePlugin")]
        private static extern void YVRAcquireVSTCameraFrame(ref VSTCameraFrameData frameData);

        [DllImport("yvrplugin")]
        private static extern void YVRGetRenderScale(string packageName, ref YVRRenderScaleBuffers renderScaleBuffers);

        [DllImport("yvrplugin")]
        private static extern void YVRSetRenderScale(string packageName, YVRRenderScale renderScale);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGetEyeCenterToVSTCameraExtrinsic(VSTCameraSourceType eyeNumberType,
                                                                       ref VSTCameraExtrinsicData data);

        [DllImport("enterprisePlugin")]
        private static extern void YVRGenerateVSTCameraUnDistortionMap(VSTCameraSourceType eyeNumberType,
                                                                       VSTCameraResolutionType resolution, int width,
                                                                       int height, float fovScale, IntPtr mapXOutput,
                                                                       IntPtr mapYOutput,
                                                                       IntPtr focalLength,
                                                                       IntPtr principlePoint);

        public static void SetVSTCameraFrequency(VSTCameraFrequencyType freq) { YVRSetVSTCameraFrequency(freq); }

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

        public static void SetVSTCameraFormat(VSTCameraFormatType formatType) { YVRSetVSTCameraFormat(formatType); }

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

        public static void GetVSTCameraIntrinsicExtrinsic(VSTCameraSourceType eyeNumberType,
                                                          ref VSTCameraIntrinsicExtrinsicData data)
        {
            YVRGetVSTCameraIntrinsicExtrinsic(eyeNumberType, ref data);
        }

        public static void GetVSTCameraIntrinsicExtrinsicRelativeToIMU(VSTCameraSourceType eyeNumberType,
                                                                       ref VSTCameraIntrinsicExtrinsicData data)
        {
            YVRGetVSTCameraIntrinsicExtrinsicRelativeToIMU(eyeNumberType, ref data);
        }

        public static void OpenVSTCamera() { YVROpenVSTCamera(); }

        public static void CloseVSTCamera() { YVRCloseVSTCamera(); }

        public static void AcquireVSTCameraFrame(ref VSTCameraFrameData frameData)
        {
            YVRAcquireVSTCameraFrame(ref frameData);
        }

        public static void GetEyeCenterToVSTCameraExtrinsic(VSTCameraSourceType eyeSourceType,
                                                            ref VSTCameraExtrinsicData data)
        {
            YVRGetEyeCenterToVSTCameraExtrinsic(eyeSourceType, ref data);
        }

        public static void GetRenderScale(string packageName, ref YVRRenderScaleBuffers renderScaleBuffers)
        {
            YVRGetRenderScale(packageName, ref renderScaleBuffers);
        }

        public static void SetRenderScale(string packageName, YVRRenderScale renderScale)
        {
            YVRSetRenderScale(packageName, renderScale);
        }

        public static void GenerateVSTCameraUnDistortionMap(VSTCameraSourceType eyeSourceType,
                                                            VSTCameraResolutionType resolution, int width, int height,
                                                            float fovScale, IntPtr mapXOutput, IntPtr mapYOutput,
                                                            IntPtr focalLength, IntPtr principlePoint)
        {
            YVRGenerateVSTCameraUnDistortionMap(eyeSourceType, resolution, width, height, fovScale, mapXOutput,
                                                mapYOutput, focalLength, principlePoint);
        }
    }
}
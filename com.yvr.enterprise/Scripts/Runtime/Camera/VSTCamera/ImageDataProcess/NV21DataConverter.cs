using Unity.Collections;
using Unity.Jobs;

namespace YVR.Enterprise.Camera
{
    public class NV21DataConverter
    {
        // These data only used for internal calculation
        private int m_Width, m_Height;

        public NativeArray<byte> rgbDataArray = default;
        public NativeArray<byte> undistortedRgbDataArray = default;
        public NativeArray<byte> normalizedRGBDataArray = default;

        public NV21DataConverter(int width, int height)
        {
            m_Width = width;
            m_Height = height;
            rgbDataArray = new NativeArray<byte>(width * height * 3, Allocator.Persistent);
            undistortedRgbDataArray = new NativeArray<byte>(width * height * 3, Allocator.Persistent);

            normalizedRGBDataArray = new NativeArray<byte>(width * height * 3, Allocator.Persistent);
        }

        public JobHandle GetNormalizeRGBDataJobHandle(NativeArray<byte> nv21Data, UndistortionMap undistortionMap)
        {
            var nv21ToRGBJob = new NV21ToRGBJob
            {
                nv21Data = nv21Data,
                rgbData = rgbDataArray,
                width = m_Width,
                height = m_Height
            };

            JobHandle nv21ToRGBJobHandle = nv21ToRGBJob.Schedule(m_Width * m_Height, 256);

            var undistortionJob = new FisheyeUndistortionJob
            {
                srcRgb = rgbDataArray,
                dstRgb = undistortedRgbDataArray,
                mapX = undistortionMap.xDataArray,
                mapY = undistortionMap.yDataArray,
                width = m_Width,
                height = m_Height,
            };

            JobHandle undistortionJobHandle = undistortionJob.Schedule(m_Width * m_Height, 256, nv21ToRGBJobHandle);

            var rotate90CCWJob = new RotateRGB90CWJob
            {
                srcRgb = undistortedRgbDataArray,
                dstRgb = normalizedRGBDataArray,
                srcWidth = m_Width,
                srcHeight = m_Height
            };

            JobHandle rgbRotateCCW90JobHandle = rotate90CCWJob.Schedule(m_Width * m_Height, 256, undistortionJobHandle);
            return rgbRotateCCW90JobHandle;
        }

        ~NV21DataConverter()
        {
            rgbDataArray.Dispose();
            normalizedRGBDataArray.Dispose();
            undistortedRgbDataArray.Dispose();
        }
    }
}
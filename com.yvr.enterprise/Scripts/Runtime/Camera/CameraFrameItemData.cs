using System;
using System.Runtime.InteropServices;

namespace YVR.Enterprise.Camera
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CameraFrameItemData
    {
        public int frameNumber;
        public int width;
        public int height;
        public int stride;
        public int format;

        /// <summary>
        ///  Exposure duration in nano seconds
        /// </summary>
        public int exposureDuration;

        /// <summary>
        /// Start of exposure timestamp in nano seconds (nanosecond CLOCK_BOOT_TIME)
        /// </summary>
        public long soeTimestamp;

        /// <summary>
        /// Start of exposure timestamp in nano seconds (nanosecond with qtimer)
        /// </summary>
        public long soeTimestampq;
        public int gain;
        public int dataSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] data;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] reserved;

        public override string ToString()
        {
            return $"frameNumber:{frameNumber},width:{width},height:{height},format:{format}," +
                   $"exposureDuration:{exposureDuration},soeTimestamp:{soeTimestamp},soeTimestampq:{soeTimestampq}," +
                   $"gain:{gain},dataSize:{dataSize}";
        }
    }
}
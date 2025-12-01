using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace YVR.Enterprise.Camera
{
    public class UndistortionMap
    {
        public NativeArray<float> xDataArray;
        public NativeArray<float> yDataArray;

        public NativeArray<float> focalLength;
        public NativeArray<float> principalPoint;

        public UndistortionMap(VSTCameraSourceType source, VSTCameraResolutionType resolution)
        {
            GetResolution(resolution,out int width, out int height);
            LoadNativeMap(source, resolution, width * height);
        }

        private void LoadNativeMap(VSTCameraSourceType source, VSTCameraResolutionType resolution,
                                   int length)
        {
            GetResolution(resolution,out int width, out int height);

            IntPtr mapXPtr = Marshal.AllocHGlobal(length * sizeof(float));
            IntPtr mapYPtr = Marshal.AllocHGlobal(length * sizeof(float));
            IntPtr focalLengthPtr = Marshal.AllocHGlobal(2 * sizeof(float));
            IntPtr principalPointPtr = Marshal.AllocHGlobal(2 * sizeof(float));
            YVRVSTCameraPlugin.GenerateVSTCameraUnDistortionMap(source, resolution, width, height, 1.0f,
                                                                mapXPtr, mapYPtr, focalLengthPtr, principalPointPtr);

            xDataArray = new NativeArray<float>(length, Allocator.Persistent);
            yDataArray = new NativeArray<float>(length, Allocator.Persistent);
            focalLength = new NativeArray<float>(2, Allocator.Persistent);
            principalPoint = new NativeArray<float>(2, Allocator.Persistent);
            unsafe
            {
                void* xPtr = xDataArray.GetUnsafePtr();
                void* yPtr = yDataArray.GetUnsafePtr();
                void* desFocalLengthPtr = focalLength.GetUnsafePtr();
                void* desPrincipalPoint = principalPoint.GetUnsafePtr();
                UnsafeUtility.MemCpy(xPtr, (void*)mapXPtr, length * sizeof(float));
                UnsafeUtility.MemCpy(yPtr, (void*)mapYPtr, length * sizeof(float));
                UnsafeUtility.MemCpy(desFocalLengthPtr, (void*)focalLengthPtr, 2 * sizeof(float));
                UnsafeUtility.MemCpy(desPrincipalPoint, (void*)principalPointPtr, 2 * sizeof(float));
            }

            Marshal.FreeHGlobal(mapXPtr);
            Marshal.FreeHGlobal(mapYPtr);
            Marshal.FreeHGlobal(focalLengthPtr);
            Marshal.FreeHGlobal(principalPointPtr);
        }

        private void GetResolution(VSTCameraResolutionType resolution, out int width, out int height)
        {
            switch (resolution)
            {
                case VSTCameraResolutionType.VSTResolution660_616:
                    width = 660;
                    height = 616;
                    break;
                case VSTCameraResolutionType.VSTResolution1320_1232:
                    width = 1320;
                    height = 1232;
                    break;
                case VSTCameraResolutionType.VSTResolution2640_2464:
                    width = 2640;
                    height = 2464;
                    break;
                default:
                    width = 660;
                    height = 616;
                    break;
            }
        }
    }
}
using System.Runtime.InteropServices;
using UnityEngine;

namespace YVR.Enterprise.Camera
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VSTCameraExtrinsicData
    {
        public Vector3 translation;
        public Quaternion rotation;
    }
}
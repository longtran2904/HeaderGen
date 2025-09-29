#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [UsedByNativeCode]
    public struct CameraProperties : IEquatable<CameraProperties>
    {

        public Plane GetShadowCullingPlane(int index);
        public void SetShadowCullingPlane(int index, Plane plane);
        public Plane GetCameraCullingPlane(int index);
        public void SetCameraCullingPlane(int index, Plane plane);
        public bool Equals(CameraProperties other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(CameraProperties left, CameraProperties right);
        public static bool operator !=(CameraProperties left, CameraProperties right);
    }
}

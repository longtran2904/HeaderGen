#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Jobs
{
    [NativeHeader("Runtime/Transform/ScriptBindings/TransformAccess.bindings.h")]
    public struct TransformAccess
    {

        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        public Vector3 localPosition { get; set; }
        public Quaternion localRotation { get; set; }
        public Vector3 localScale { get; set; }
        public Matrix4x4 localToWorldMatrix { get; }
        public Matrix4x4 worldToLocalMatrix { get; }
        public bool isValid { get; }

        public void SetPositionAndRotation(Vector3 position, Quaternion rotation);
        public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation);
        public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation);
        public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public struct BoundingSphere
    {

        public Vector3 position;
        public float radius;

        public BoundingSphere(Vector3 pos, float rad);
        public BoundingSphere(Vector4 packedSphere);
    }
}

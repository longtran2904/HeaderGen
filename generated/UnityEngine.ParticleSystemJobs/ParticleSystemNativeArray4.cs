#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using System.Reflection;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
    [DefaultMember("Item")]
    public struct ParticleSystemNativeArray4
    {

        public NativeArray<float> x;
        public NativeArray<float> y;
        public NativeArray<float> z;
        public NativeArray<float> w;

        public Vector4 this[int index] { get; set; }
    }
}

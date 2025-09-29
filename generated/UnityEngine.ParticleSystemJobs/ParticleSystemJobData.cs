#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
    public struct ParticleSystemJobData
    {

        public int count { get; }
        public ParticleSystemNativeArray3 positions { get; }
        public ParticleSystemNativeArray3 velocities { get; }
        public ParticleSystemNativeArray3 axisOfRotations { get; }
        public ParticleSystemNativeArray3 rotations { get; }
        public ParticleSystemNativeArray3 rotationalSpeeds { get; }
        public ParticleSystemNativeArray3 sizes { get; }
        public NativeArray<Color32> startColors { get; }
        public NativeArray<float> aliveTimePercent { get; }
        public NativeArray<float> inverseStartLifetimes { get; }
        public NativeArray<uint> randomSeeds { get; }
        public ParticleSystemNativeArray4 customData1 { get; }
        public ParticleSystemNativeArray4 customData2 { get; }
        public NativeArray<int> meshIndices { get; }
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Profiling
{
    [UsedByNativeCode]
    public sealed class Recorder
    {

        ~Recorder();

        public bool isValid { get; }
        public bool enabled { get; set; }
        public long elapsedNanoseconds { get; }
        public long gpuElapsedNanoseconds { get; }
        public int sampleBlockCount { get; }
        public int gpuSampleBlockCount { get; }

        public static Recorder Get(string samplerName);
        public void FilterToCurrentThread();
        public void CollectFromAllThreads();
    }
}

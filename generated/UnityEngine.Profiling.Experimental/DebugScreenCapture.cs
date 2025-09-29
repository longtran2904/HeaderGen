#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;

namespace UnityEngine.Profiling.Experimental
{
    public struct DebugScreenCapture
    {
        public NativeArray<byte> rawImageDataReference { get; set; }
        public TextureFormat imageFormat { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Graphics/Texture.h")]
    [NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
    [NativeHeader("Runtime/Shaders/ComputeShader.h")]
    [UsedByNativeCode]
    public struct AsyncGPUReadbackRequest
    {

        public bool done { get; }
        public bool hasError { get; }
        public int layerCount { get; }
        public int layerDataSize { get; }
        public int width { get; }
        public int height { get; }
        public int depth { get; }

        public void Update();
        public void WaitForCompletion();
        public NativeArray<T> GetData<T>(int layer = 0) where T : struct;
    }
}

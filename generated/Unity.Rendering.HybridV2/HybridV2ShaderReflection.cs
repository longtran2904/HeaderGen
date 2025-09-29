#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Rendering.HybridV2
{
    public class HybridV2ShaderReflection
    {
        public HybridV2ShaderReflection();

        [FreeFunction("Shader::GetDOTSReflectionVersionNumber")]
        public static uint GetDOTSReflectionVersionNumber();
        public static NativeArray<DOTSInstancingCbuffer> GetDOTSInstancingCbuffers(Shader shader);
        public static NativeArray<DOTSInstancingProperty> GetDOTSInstancingProperties(Shader shader);
    }
}

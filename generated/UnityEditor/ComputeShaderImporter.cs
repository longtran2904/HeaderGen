#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/AssetPipeline/ComputeShaderImporter.h")]
    public sealed class ComputeShaderImporter : AssetImporter
    {

        public ComputeShaderImporter();

        [NativeProperty("PreprocessorOverride")]
        public PreprocessorOverride preprocessorOverride { get; set; }
    }
}

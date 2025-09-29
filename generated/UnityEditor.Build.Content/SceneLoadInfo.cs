#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [NativeAsStruct]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    [NativeType(CodegenOptions = CodegenOptions.Custom)]
    [UsedByNativeCode]
    public class SceneLoadInfo
    {

        public SceneLoadInfo();

        public GUID asset { get; set; }
        public string address { get; set; }
        public string internalName { get; set; }
    }
}

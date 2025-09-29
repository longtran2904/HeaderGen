#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeHeader("Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.bindings.h")]
    [NativeType(IntermediateScriptingStructName = "MonoClipAnimationInfoCurve", CodegenOptions = CodegenOptions.Custom)]
    [UsedByNativeCode]
    public struct ClipAnimationInfoCurve
    {

        public string name;
        public AnimationCurve curve;
    }
}

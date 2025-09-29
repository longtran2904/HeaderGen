#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
    [NativeType(Header = "Modules/Animation/Constraints/ConstraintSource.h", IntermediateScriptingStructName = "MonoConstraintSource", CodegenOptions = CodegenOptions.Custom)]
    [UsedByNativeCode]
    public struct ConstraintSource
    {

        public Transform sourceTransform { get; set; }
        public float weight { get; set; }
    }
}

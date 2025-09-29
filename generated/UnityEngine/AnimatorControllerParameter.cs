#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeAsStruct]
    [NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
    [NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
    [UsedByNativeCode]
    public class AnimatorControllerParameter
    {

        public AnimatorControllerParameter();

        public string name { get; set; }
        public int nameHash { get; }
        public AnimatorControllerParameterType type { get; set; }
        public float defaultFloat { get; set; }
        public int defaultInt { get; set; }
        public bool defaultBool { get; set; }

        public override bool Equals(object o);
        public override int GetHashCode();
    }
}

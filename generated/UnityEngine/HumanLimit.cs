#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/HumanDescription.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
    [NativeType(CodegenOptions.Custom, "MonoHumanLimit")]
    public struct HumanLimit
    {
        public bool useDefaultValues { get; set; }
        public Vector3 min { get; set; }
        public Vector3 max { get; set; }
        public Vector3 center { get; set; }
        public float axisLength { get; set; }
    }
}

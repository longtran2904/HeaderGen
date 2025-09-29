#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/HumanDescription.h")]
    [NativeType(CodegenOptions.Custom, "MonoHumanBone")]
    [RequiredByNativeCode]
    public struct HumanBone
    {
        [NativeName("m_Limit")]
        public HumanLimit limit;

        public string boneName { get; set; }
        public string humanName { get; set; }
    }
}

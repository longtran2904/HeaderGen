#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/AnimatorInfo.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
    [UsedByNativeCode]
    public struct AnimatorClipInfo
    {

        public AnimationClip clip { get; }
        public float weight { get; }
    }
}

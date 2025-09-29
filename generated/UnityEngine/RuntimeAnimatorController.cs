#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [ExcludeFromObjectFactory]
    [NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
    [UsedByNativeCode]
    public class RuntimeAnimatorController : Object
    {

        protected RuntimeAnimatorController();

        public AnimationClip[] animationClips { get; }
    }
}

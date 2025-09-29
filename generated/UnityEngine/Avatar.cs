#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/Avatar.h")]
    [UsedByNativeCode]
    public class Avatar : Object
    {

        public bool isValid { get; }
        public bool isHuman { get; }
        public HumanDescription humanDescription { get; }
    }
}

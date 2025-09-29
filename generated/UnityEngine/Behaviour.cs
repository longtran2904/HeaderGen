#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Mono/MonoBehaviour.h")]
    [UsedByNativeCode]
    public class Behaviour : Component
    {

        public Behaviour();

        [NativeProperty]
        [RequiredByNativeCode]
        public bool enabled { get; set; }
        [NativeProperty]
        public bool isActiveAndEnabled { get; }
    }
}

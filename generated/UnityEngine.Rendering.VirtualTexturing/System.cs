#region UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Rendering.VirtualTexturing
{
    [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
    [StaticAccessor("VirtualTexturing::System", StaticAccessorType.DoubleColon)]
    public static class System
    {

        public const int AllMips = 2147483647;

        [NativeThrows]
        public static void Update();
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Export/Graphics/RenderingCommandBufferExtensions.bindings.h")]
    [UsedByNativeCode]
    public static class CommandBufferExtensions
    {

        [NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
        public static void SwitchIntoFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
        [NativeConditional("UNITY_XBOXONE || UNITY_GAMECORE_XBOXONE")]
        public static void SwitchOutOfFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents);
    }
}

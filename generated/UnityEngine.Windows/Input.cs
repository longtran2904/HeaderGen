#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Windows
{
    [NativeHeader("PlatformDependent/Win/Bindings/InputBindings.h")]
    public static class Input
    {

        public static void ForwardRawInput(nint rawInputHeaderIndices, nint rawInputDataIndices, uint indicesCount, nint rawInputData, uint rawInputDataSize);
        public static void ForwardRawInput(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize);
    }
}

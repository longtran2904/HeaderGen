#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngineInternal
{
    [NativeHeader("Runtime/Export/GI/GIDebugVisualisation.bindings.h")]
    public static class GIDebugVisualisation
    {
        public static bool cycleMode { get; }
        public static bool pauseCycleMode { get; }
        public static GITextureType texType { get; set; }

        [FreeFunction]
        public static void ResetRuntimeInputTextures();
        [FreeFunction]
        public static void PlayCycleMode();
        [FreeFunction]
        public static void PauseCycleMode();
        [FreeFunction]
        public static void StopCycleMode();
        [FreeFunction]
        public static void CycleSkipSystems(int skip);
        [FreeFunction]
        public static void CycleSkipInstances(int skip);
    }
}

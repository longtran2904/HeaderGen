#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Diagnostics
{
    [NativeHeader("Runtime/Export/Diagnostics/DiagnosticsUtils.bindings.h")]
    public static class Utils
    {

        [FreeFunction("DiagnosticsUtils_Bindings::ForceCrash", ThrowsException = True)]
        public static void ForceCrash(ForcedCrashCategory crashCategory);
        [FreeFunction("DiagnosticsUtils_Bindings::NativeAssert")]
        public static void NativeAssert(string message);
        [FreeFunction("DiagnosticsUtils_Bindings::NativeError")]
        public static void NativeError(string message);
        [FreeFunction("DiagnosticsUtils_Bindings::NativeWarning")]
        public static void NativeWarning(string message);
    }
}

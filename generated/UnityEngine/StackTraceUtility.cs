#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Security;
using UnityEngine.Scripting;

namespace UnityEngine
{
    public static class StackTraceUtility
    {
        [RequiredByNativeCode]
        [SecuritySafeCritical]
        public static string ExtractStackTrace();
        public static string ExtractStringFromException(object exception);
    }
}

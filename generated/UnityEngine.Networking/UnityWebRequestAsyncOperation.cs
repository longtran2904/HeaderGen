#region UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
    [NativeHeader("UnityWebRequestScriptingClasses.h")]
    [UsedByNativeCode]
    public class UnityWebRequestAsyncOperation : AsyncOperation
    {
        public UnityWebRequestAsyncOperation();

        public UnityWebRequest webRequest { get; }
    }
}

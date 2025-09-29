#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCMessage.h")]
    [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
    [UsedByNativeCode]
    public class Message
    {

        ~Message();

        [NativeMethod(IsThreadSafe = True)]
        public Severity severity { get; }
        [NativeMethod(IsThreadSafe = True)]
        public string message { get; }

        public void Dispose();
        public void Show();
        [NativeType("Editor/Src/VersionControl/VCMessage.h")]
        public enum Severity
        {

            Data = 0,
            Verbose = 1,
            Info = 2,
            Warning = 3,
            Error = 4
        }
    }
}

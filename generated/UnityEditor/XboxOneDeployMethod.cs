#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Runtime/Serialize/BuildTarget.h")]
    public enum XboxOneDeployMethod
    {

        Push = 0,
        RunFromPC = 2,
        Package = 3,
        PackageStreaming = 4
    }
}

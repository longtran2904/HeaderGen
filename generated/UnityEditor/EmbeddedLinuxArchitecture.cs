#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Editor/Src/EditorUserBuildSettings.h")]
    public enum EmbeddedLinuxArchitecture
    {
        [InspectorName("Arm64")]
        Arm64 = 0,
        [InspectorName("Arm32")]
        Arm32 = 1,
        [InspectorName("X64")]
        X64 = 2,
        [InspectorName("X86")]
        X86 = 3
    }
}

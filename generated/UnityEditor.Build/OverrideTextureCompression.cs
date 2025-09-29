#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Build
{
    [NativeType(Header = "Editor/Src/EditorUserBuildSettings.h")]
    public enum OverrideTextureCompression
    {
        NoOverride = 0,
        ForceUncompressed = 1,
        ForceFastCompressor = 2
    }
}

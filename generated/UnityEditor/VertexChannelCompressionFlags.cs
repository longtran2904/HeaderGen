#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Flags]
    public enum VertexChannelCompressionFlags
    {
        None = 0,
        Position = 1,
        Normal = 2,
        Tangent = 4,
        Color = 8,
        TexCoord0 = 16,
        TexCoord1 = 32,
        TexCoord2 = 64,
        TexCoord3 = 128,
        [Obsolete("Use Position instead (UnityUpgradable) -> Position", False)]
        kPosition = 1,
        [Obsolete("Use Normal instead (UnityUpgradable) -> Normal", False)]
        kNormal = 2,
        [Obsolete("Use Color instead (UnityUpgradable) -> Color", False)]
        kColor = 4,
        [Obsolete("Use TexCoord0 instead (UnityUpgradable) -> TexCoord0", False)]
        kUV0 = 8,
        [Obsolete("Use TexCoord1 instead (UnityUpgradable) -> TexCoord1", False)]
        kUV1 = 16,
        [Obsolete("Use TexCoord2 instead (UnityUpgradable) -> TexCoord2", False)]
        kUV2 = 32,
        [Obsolete("Use TexCoord3 instead (UnityUpgradable) -> TexCoord3", False)]
        kUV3 = 64,
        [Obsolete("Use Tangent instead (UnityUpgradable) -> Tangent", False)]
        kTangent = 128
    }
}

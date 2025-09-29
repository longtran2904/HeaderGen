#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [RequiredByNativeCode]
    public enum TextureImporterType
    {
        Default = 0,
        NormalMap = 1,
        GUI = 2,
        Sprite = 8,
        Cursor = 7,
        Cookie = 4,
        Lightmap = 6,
        SingleChannel = 10,
        Shadowmask = 11,
        DirectionalLightmap = 12,
        [Obsolete("Use Default (UnityUpgradable) -> Default", True)]
        Image = -2147483648,
        [Obsolete("Use NormalMap (UnityUpgradable) -> NormalMap", True)]
        Bump = -1,
        [Obsolete("Use importer.textureShape = TextureImporterShape.TextureCube", True)]
        Cubemap = -3,
        [Obsolete("Use a texture setup as a cubemap with glossy reflection instead", True)]
        Reflection = -3,
        [Obsolete("Use Default instead. All texture types now have an Advanced foldout (UnityUpgradable) -> Default", True)]
        Advanced = -5,
        [Obsolete("HDRI is not supported anymore", True)]
        HDRI = -9
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public enum SpritePackerMode
    {
        Disabled = 0,
        [Obsolete("Sprite Packing Tags are deprecated. Please use Sprite Atlas asset.")]
        BuildTimeOnly = 1,
        [Obsolete("Sprite Packing Tags are deprecated. Please use Sprite Atlas asset.")]
        AlwaysOn = 2,
        BuildTimeOnlyAtlas = 3,
        AlwaysOnAtlas = 4,
        SpriteAtlasV2 = 5
    }
}

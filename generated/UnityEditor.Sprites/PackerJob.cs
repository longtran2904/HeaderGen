#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Sprites
{
    [NativeHeader("Editor/Src/SpritePacker/SpritePacker.h")]
    public sealed class PackerJob
    {

        public void AddAtlas(string atlasName, AtlasSettings settings);
        public void AssignToAtlas(string atlasName, Sprite sprite, SpritePackingMode packingMode, SpritePackingRotation packingRotation);
    }
}

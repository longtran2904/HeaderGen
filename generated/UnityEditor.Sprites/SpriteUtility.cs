#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Sprites
{
    [NativeHeader("Editor/Mono/SpritesEditor.bindings.h")]
    [StaticAccessor("SpriteUtilityBindings", StaticAccessorType.DoubleColon)]
    public sealed class SpriteUtility
    {

        public SpriteUtility();

        [NativeThrows]
        public static Texture2D GetSpriteTexture([NotNull("ArgumentNullException")] Sprite sprite, bool getAtlasData);
        [Obsolete("Use Sprite.vertices API instead. This data is the same for packed and unpacked sprites.")]
        public static Vector2[] GetSpriteMesh(Sprite sprite, bool getAtlasData);
        [NativeThrows]
        public static Vector2[] GetSpriteUVs([NotNull("ArgumentNullException")] Sprite sprite, bool getAtlasData);
        [Obsolete("Use Sprite.triangles API instead. This data is the same for packed and unpacked sprites.")]
        public static ushort[] GetSpriteIndices(Sprite sprite, bool getAtlasData);
    }
}

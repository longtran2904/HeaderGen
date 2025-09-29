#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Sprites
{
    [NativeHeader("Editor/Src/SpritePacker/SpritePacker.h")]
    public sealed class Packer
    {
        public static string kDefaultPolicy;

        public Packer();

        public static string[] atlasNames { get; }
        public static string[] Policies { get; }
        public static string SelectedPolicy { get; set; }

        [FreeFunction("SpritePacker::GetTexturesForAtlas")]
        public static Texture2D[] GetTexturesForAtlas(string atlasName);
        [FreeFunction("SpritePacker::GetAlphaTexturesForAtlas")]
        public static Texture2D[] GetAlphaTexturesForAtlas(string atlasName);
        [FreeFunction("SpritePacker::RebuildAtlasCacheIfNeededFromScript")]
        [Obsolete("Sprite Packing Tags are deprecated. Please use Sprite Atlas asset.")]
        public static void RebuildAtlasCacheIfNeeded(BuildTarget target, bool displayProgressBar, Execution execution);
        [Obsolete("Sprite Packing Tags are deprecated. Please use Sprite Atlas asset.")]
        public static void RebuildAtlasCacheIfNeeded(BuildTarget target, bool displayProgressBar);
        [Obsolete("Sprite Packing Tags are deprecated. Please use Sprite Atlas asset.")]
        public static void RebuildAtlasCacheIfNeeded(BuildTarget target);
        public static void GetAtlasDataForSprite(Sprite sprite, out string atlasName, out Texture2D atlasTexture);

        public enum Execution
        {
            Normal = 0,
            ForceRegroup = 1
        }
    }
}

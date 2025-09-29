#region UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeClass("TextRendering::Font")]
    [NativeHeader("Modules/TextRendering/Public/Font.h")]
    [NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
    [StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
    public sealed class Font : Object
    {

        public Font();
        public Font(string name);

        public Material material { get; set; }
        public string[] fontNames { get; set; }
        public bool dynamic { get; }
        public int ascent { get; }
        public int fontSize { get; }
        public CharacterInfo[] characterInfo { get; set; }
        [NativeProperty("LineSpacing", False, TargetType.Function)]
        public int lineHeight { get; }
        [Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
        public FontTextureRebuildCallback textureRebuildCallback { get; set; }

        public static event Action<Font> textureRebuilt;

        public static Font CreateDynamicFontFromOSFont(string fontname, int size);
        public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size);
        public static int GetMaxVertsForString(string str);
        public bool HasCharacter(char c);
        public static string[] GetOSInstalledFontNames();
        public static string[] GetPathsToOSFonts();
        [FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
        public bool GetCharacterInfo(char ch, out CharacterInfo info, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style);
        [ExcludeFromDocs]
        public bool GetCharacterInfo(char ch, out CharacterInfo info, int size);
        [ExcludeFromDocs]
        public bool GetCharacterInfo(char ch, out CharacterInfo info);
        public void RequestCharactersInTexture(string characters, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style);
        [ExcludeFromDocs]
        public void RequestCharactersInTexture(string characters, int size);
        [ExcludeFromDocs]
        public void RequestCharactersInTexture(string characters);
        public delegate void FontTextureRebuildCallback();
    }
}

#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
    public struct StyleFontDefinition : IEquatable<StyleFontDefinition>, IStyleValue<FontDefinition>
    {

        public StyleFontDefinition(FontDefinition f);
        public StyleFontDefinition(FontAsset f);
        public StyleFontDefinition(Font f);
        public StyleFontDefinition(StyleKeyword keyword);

        public FontDefinition value { get; set; }
        public StyleKeyword keyword { get; set; }

        public bool Equals(StyleFontDefinition other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(StyleFontDefinition left, StyleFontDefinition right);
        public static bool operator !=(StyleFontDefinition left, StyleFontDefinition right);

        public static implicit operator StyleFontDefinition(StyleKeyword keyword);
        public static implicit operator StyleFontDefinition(FontDefinition f);
    }
}

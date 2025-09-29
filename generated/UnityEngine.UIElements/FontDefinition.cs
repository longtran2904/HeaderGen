#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
    public struct FontDefinition : IEquatable<FontDefinition>
    {

        public Font font { get; set; }
        public FontAsset fontAsset { get; set; }

        public static FontDefinition FromFont(Font f);
        public static FontDefinition FromSDFFont(FontAsset f);
        public override string ToString();
        public bool Equals(FontDefinition other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(FontDefinition left, FontDefinition right);
        public static bool operator !=(FontDefinition left, FontDefinition right);
    }
}

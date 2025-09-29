#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct TextShadow : IEquatable<TextShadow>
    {
        public Vector2 offset;
        public float blurRadius;
        public Color color;

        public override bool Equals(object obj);
        public bool Equals(TextShadow other);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(TextShadow style1, TextShadow style2);
        public static bool operator !=(TextShadow style1, TextShadow style2);
    }
}

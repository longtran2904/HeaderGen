#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct Background : IEquatable<Background>
    {
        [Obsolete("Use Background.FromTexture2D instead")]
        public Background(Texture2D t);

        public Texture2D texture { get; set; }
        public Sprite sprite { get; set; }
        public RenderTexture renderTexture { get; set; }
        public VectorImage vectorImage { get; set; }

        public static Background FromTexture2D(Texture2D t);
        public static Background FromRenderTexture(RenderTexture rt);
        public static Background FromSprite(Sprite s);
        public static Background FromVectorImage(VectorImage vi);
        public bool Equals(Background other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Background lhs, Background rhs);
        public static bool operator !=(Background lhs, Background rhs);
    }
}

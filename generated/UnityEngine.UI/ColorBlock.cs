#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.UI
{
    public struct ColorBlock : IEquatable<ColorBlock>
    {

        public static ColorBlock defaultColorBlock;

        public Color normalColor { get; set; }
        public Color highlightedColor { get; set; }
        public Color pressedColor { get; set; }
        public Color selectedColor { get; set; }
        public Color disabledColor { get; set; }
        public float colorMultiplier { get; set; }
        public float fadeDuration { get; set; }

        public override bool Equals(object obj);
        public bool Equals(ColorBlock other);
        public override int GetHashCode();

        public static bool operator ==(ColorBlock point1, ColorBlock point2);
        public static bool operator !=(ColorBlock point1, ColorBlock point2);
    }
}

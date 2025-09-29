#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
    [UsedByNativeCode]
    public struct GlyphRect : IEquatable<GlyphRect>
    {

        public GlyphRect(int x, int y, int width, int height);
        public GlyphRect(Rect rect);

        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public static GlyphRect zero { get; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(GlyphRect other);

        public static bool operator ==(GlyphRect lhs, GlyphRect rhs);
        public static bool operator !=(GlyphRect lhs, GlyphRect rhs);
    }
}

#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
    [UsedByNativeCode]
    public struct GlyphMetrics : IEquatable<GlyphMetrics>
    {
        public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance);

        public float width { get; set; }
        public float height { get; set; }
        public float horizontalBearingX { get; set; }
        public float horizontalBearingY { get; set; }
        public float horizontalAdvance { get; set; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(GlyphMetrics other);

        public static bool operator ==(GlyphMetrics lhs, GlyphMetrics rhs);
        public static bool operator !=(GlyphMetrics lhs, GlyphMetrics rhs);
    }
}

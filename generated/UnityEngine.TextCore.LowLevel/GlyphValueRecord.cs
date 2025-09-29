#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using System;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
    [UsedByNativeCode]
    public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
    {

        public GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance);

        public float xPlacement { get; set; }
        public float yPlacement { get; set; }
        public float xAdvance { get; set; }
        public float yAdvance { get; set; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(GlyphValueRecord other);

        public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b);
        [ExcludeFromDocs]
        public static GlyphValueRecord operator *(GlyphValueRecord a, float emScale);
        public static bool operator ==(GlyphValueRecord lhs, GlyphValueRecord rhs);
        public static bool operator !=(GlyphValueRecord lhs, GlyphValueRecord rhs);
    }
}

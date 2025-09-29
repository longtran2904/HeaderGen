#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using System;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
    [UsedByNativeCode]
    public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
    {
        public GlyphAdjustmentRecord(uint glyphIndex, GlyphValueRecord glyphValueRecord);

        public uint glyphIndex { get; set; }
        public GlyphValueRecord glyphValueRecord { get; set; }

        [ExcludeFromDocs]
        public override int GetHashCode();
        [ExcludeFromDocs]
        public override bool Equals(object obj);
        [ExcludeFromDocs]
        public bool Equals(GlyphAdjustmentRecord other);

        [ExcludeFromDocs]
        public static bool operator ==(GlyphAdjustmentRecord lhs, GlyphAdjustmentRecord rhs);
        [ExcludeFromDocs]
        public static bool operator !=(GlyphAdjustmentRecord lhs, GlyphAdjustmentRecord rhs);
    }
}

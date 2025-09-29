#region UnityEngine.TextCoreFontEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreFontEngineModule.dll
#endregion

using System;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
    [UsedByNativeCode]
    public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
    {
        public GlyphPairAdjustmentRecord(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord);

        public GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
        public GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
        public FontFeatureLookupFlags featureLookupFlags { get; set; }

        [ExcludeFromDocs]
        public override int GetHashCode();
        [ExcludeFromDocs]
        public override bool Equals(object obj);
        [ExcludeFromDocs]
        public bool Equals(GlyphPairAdjustmentRecord other);

        [ExcludeFromDocs]
        public static bool operator ==(GlyphPairAdjustmentRecord lhs, GlyphPairAdjustmentRecord rhs);
        [ExcludeFromDocs]
        public static bool operator !=(GlyphPairAdjustmentRecord lhs, GlyphPairAdjustmentRecord rhs);
    }
}

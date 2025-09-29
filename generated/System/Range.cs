#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public readonly struct Range : IEquatable<Range>
    {

        public Range(Index start, Index end);

        public Index Start { get; }
        public Index End { get; }
        public static Range All { get; }

        public override bool Equals(object value);
        public bool Equals(Range other);
        public override int GetHashCode();
        public override string ToString();
        public static Range StartAt(Index start);
        public static Range EndAt(Index end);
        public (int Offset, int Length) GetOffsetAndLength(int length);
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public readonly struct Index : IEquatable<Index>
    {

        public Index(int value, bool fromEnd = False);

        public static Index Start { get; }
        public static Index End { get; }
        public int Value { get; }
        public bool IsFromEnd { get; }

        public static Index FromStart(int value);
        public static Index FromEnd(int value);
        public int GetOffset(int length);
        public override bool Equals(object value);
        public bool Equals(Index other);
        public override int GetHashCode();
        public override string ToString();

        public static implicit operator Index(int value);
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public sealed class SortVersion : IEquatable<SortVersion>
    {

        public SortVersion(int fullVersion, Guid sortId);

        public int FullVersion { get; }
        public Guid SortId { get; }

        public override bool Equals(object obj);
        public bool Equals(SortVersion other);
        public override int GetHashCode();

        public static bool operator ==(SortVersion left, SortVersion right);
        public static bool operator !=(SortVersion left, SortVersion right);
    }
}

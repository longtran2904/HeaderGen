#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public sealed class SortKey
    {

        public string OriginalString { get; }
        public byte[] KeyData { get; }

        public static int Compare(SortKey sortkey1, SortKey sortkey2);
        public override bool Equals(object value);
        public override int GetHashCode();
        public override string ToString();
    }
}

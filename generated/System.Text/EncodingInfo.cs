#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    public sealed class EncodingInfo
    {

        public EncodingInfo(EncodingProvider provider, int codePage, string name, string displayName);

        public int CodePage { get; }
        public string Name { get; }
        public string DisplayName { get; }

        public Encoding GetEncoding();
        public override bool Equals(object value);
        public override int GetHashCode();
    }
}

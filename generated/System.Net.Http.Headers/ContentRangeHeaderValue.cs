#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public class ContentRangeHeaderValue : ICloneable
    {
        public ContentRangeHeaderValue(long from, long to, long length);
        public ContentRangeHeaderValue(long length);
        public ContentRangeHeaderValue(long from, long to);

        public string Unit { get; set; }
        public long? From { get; }
        public long? To { get; }
        public long? Length { get; }
        public bool HasLength { get; }
        public bool HasRange { get; }

        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
        public static ContentRangeHeaderValue Parse(string input);
        public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue);
    }
}

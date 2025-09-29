#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public class StringWithQualityHeaderValue : ICloneable
    {
        public StringWithQualityHeaderValue(string value);
        public StringWithQualityHeaderValue(string value, double quality);

        public string Value { get; }
        public double? Quality { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static StringWithQualityHeaderValue Parse(string input);
        public static bool TryParse(string input, out StringWithQualityHeaderValue parsedValue);
    }
}

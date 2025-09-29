#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public class NameValueHeaderValue : ICloneable
    {

        public NameValueHeaderValue(string name);
        public NameValueHeaderValue(string name, string value);
        protected internal NameValueHeaderValue(NameValueHeaderValue source);

        public string Name { get; }
        public string Value { get; set; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public static NameValueHeaderValue Parse(string input);
        public static bool TryParse(string input, out NameValueHeaderValue parsedValue);
        public override string ToString();
    }
}

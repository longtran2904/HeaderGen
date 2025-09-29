#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

namespace System.Net.Http.Headers
{
    public class AuthenticationHeaderValue : ICloneable
    {

        public AuthenticationHeaderValue(string scheme);
        public AuthenticationHeaderValue(string scheme, string parameter);

        public string Scheme { get; }
        public string Parameter { get; }

        public override string ToString();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public static AuthenticationHeaderValue Parse(string input);
        public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue);
    }
}

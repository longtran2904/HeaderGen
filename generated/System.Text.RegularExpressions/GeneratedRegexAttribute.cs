#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

namespace System.Text.RegularExpressions
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = False, Inherited = False)]
    public sealed class GeneratedRegexAttribute : Attribute
    {
        public GeneratedRegexAttribute(string pattern);
        public GeneratedRegexAttribute(string pattern, RegexOptions options);
        public GeneratedRegexAttribute(string pattern, RegexOptions options, string cultureName);
        public GeneratedRegexAttribute(string pattern, RegexOptions options, int matchTimeoutMilliseconds);
        public GeneratedRegexAttribute(string pattern, RegexOptions options, int matchTimeoutMilliseconds, string cultureName);

        public string Pattern { get; }
        public RegexOptions Options { get; }
        public int MatchTimeoutMilliseconds { get; }
        public string CultureName { get; }
    }
}

#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

namespace System.Text.RegularExpressions
{
    [Obsolete("Regex.CompileToAssembly is obsolete and not supported. Use the GeneratedRegexAttribute with the regular expression source generator instead.", DiagnosticId = "SYSLIB0036", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
    public class RegexCompilationInfo
    {

        public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic);
        public RegexCompilationInfo(string pattern, RegexOptions options, string name, string fullnamespace, bool ispublic, TimeSpan matchTimeout);

        public bool IsPublic { get; set; }
        public TimeSpan MatchTimeout { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public RegexOptions Options { get; set; }
        public string Pattern { get; set; }
    }
}

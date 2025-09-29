#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace System.Text.RegularExpressions
{
    public class Regex : ISerializable
    {
        protected internal string pattern;
        protected internal RegexOptions roptions;
        protected internal RegexRunnerFactory factory;
        protected internal Hashtable caps;
        protected internal Hashtable capnames;
        protected internal string[] capslist;
        protected internal int capsize;
        protected internal TimeSpan internalMatchTimeout;
        public static readonly TimeSpan InfiniteMatchTimeout;

        protected Regex();
        public Regex(string pattern);
        public Regex(string pattern, RegexOptions options);
        public Regex(string pattern, RegexOptions options, TimeSpan matchTimeout);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected Regex(SerializationInfo info, StreamingContext context);

        [CLSCompliant(False)]
        protected IDictionary Caps { get; set; }
        [CLSCompliant(False)]
        protected IDictionary CapNames { get; set; }
        public RegexOptions Options { get; }
        public bool RightToLeft { get; }
        public static int CacheSize { get; set; }
        public TimeSpan MatchTimeout { get; }

        protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout);
        [Obsolete("Regex.CompileToAssembly is obsolete and not supported. Use the GeneratedRegexAttribute with the regular expression source generator instead.", DiagnosticId = "SYSLIB0036", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname);
        [Obsolete("Regex.CompileToAssembly is obsolete and not supported. Use the GeneratedRegexAttribute with the regular expression source generator instead.", DiagnosticId = "SYSLIB0036", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes);
        [Obsolete("Regex.CompileToAssembly is obsolete and not supported. Use the GeneratedRegexAttribute with the regular expression source generator instead.", DiagnosticId = "SYSLIB0036", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void CompileToAssembly(RegexCompilationInfo[] regexinfos, AssemblyName assemblyname, CustomAttributeBuilder[] attributes, string resourceFile);
        public static string Escape(string str);
        public static string Unescape(string str);
        public override string ToString();
        public string[] GetGroupNames();
        public int[] GetGroupNumbers();
        public string GroupNameFromNumber(int i);
        public int GroupNumberFromName(string name);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete mechanisms for Regex extensibility. It is not supported.", DiagnosticId = "SYSLIB0052", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected void InitializeReferences();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete mechanisms for Regex extensibility. It is not supported.", DiagnosticId = "SYSLIB0052", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected bool UseOptionC();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete mechanisms for Regex extensibility. It is not supported.", DiagnosticId = "SYSLIB0052", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected bool UseOptionR();
        public int Count(string input);
        public int Count(ReadOnlySpan<char> input);
        public int Count(ReadOnlySpan<char> input, int startat);
        public static int Count(string input, string pattern);
        public static int Count(string input, string pattern, RegexOptions options);
        public static int Count(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public static int Count(ReadOnlySpan<char> input, string pattern);
        public static int Count(ReadOnlySpan<char> input, string pattern, RegexOptions options);
        public static int Count(ReadOnlySpan<char> input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public static bool IsMatch(string input, string pattern);
        public static bool IsMatch(ReadOnlySpan<char> input, string pattern);
        public static bool IsMatch(string input, string pattern, RegexOptions options);
        public static bool IsMatch(ReadOnlySpan<char> input, string pattern, RegexOptions options);
        public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public static bool IsMatch(ReadOnlySpan<char> input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public bool IsMatch(string input);
        public bool IsMatch(string input, int startat);
        public bool IsMatch(ReadOnlySpan<char> input);
        public bool IsMatch(ReadOnlySpan<char> input, int startat);
        public static Match Match(string input, string pattern);
        public static Match Match(string input, string pattern, RegexOptions options);
        public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public Match Match(string input);
        public Match Match(string input, int startat);
        public Match Match(string input, int beginning, int length);
        public static MatchCollection Matches(string input, string pattern);
        public static MatchCollection Matches(string input, string pattern, RegexOptions options);
        public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public MatchCollection Matches(string input);
        public MatchCollection Matches(string input, int startat);
        public static string Replace(string input, string pattern, string replacement);
        public static string Replace(string input, string pattern, string replacement, RegexOptions options);
        public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout);
        public string Replace(string input, string replacement);
        public string Replace(string input, string replacement, int count);
        public string Replace(string input, string replacement, int count, int startat);
        public static string Replace(string input, string pattern, MatchEvaluator evaluator);
        public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options);
        public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout);
        public string Replace(string input, MatchEvaluator evaluator);
        public string Replace(string input, MatchEvaluator evaluator, int count);
        public string Replace(string input, MatchEvaluator evaluator, int count, int startat);
        public static string[] Split(string input, string pattern);
        public static string[] Split(string input, string pattern, RegexOptions options);
        public static string[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public string[] Split(string input);
        public string[] Split(string input, int count);
        public string[] Split(string input, int count, int startat);
        public static ValueMatchEnumerator EnumerateMatches(ReadOnlySpan<char> input, string pattern);
        public static ValueMatchEnumerator EnumerateMatches(ReadOnlySpan<char> input, string pattern, RegexOptions options);
        public static ValueMatchEnumerator EnumerateMatches(ReadOnlySpan<char> input, string pattern, RegexOptions options, TimeSpan matchTimeout);
        public ValueMatchEnumerator EnumerateMatches(ReadOnlySpan<char> input);
        public ValueMatchEnumerator EnumerateMatches(ReadOnlySpan<char> input, int startat);

        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct ValueMatchEnumerator
        {
            public ValueMatch Current { get; }

            public ValueMatchEnumerator GetEnumerator();
            public bool MoveNext();
        }
    }
}

#region System.Text.RegularExpressions, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Text.RegularExpressions.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Text.RegularExpressions
{
    public class RegexMatchTimeoutException : TimeoutException
    {

        public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout);
        public RegexMatchTimeoutException();
        public RegexMatchTimeoutException(string message);
        public RegexMatchTimeoutException(string message, Exception inner);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context);

        public string Input { get; }
        public string Pattern { get; }
        public TimeSpan MatchTimeout { get; }
    }
}

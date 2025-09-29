#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public class ArgumentNullException : ArgumentException
    {

        public ArgumentNullException();
        public ArgumentNullException(string paramName);
        public ArgumentNullException(string message, Exception innerException);
        public ArgumentNullException(string paramName, string message);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ArgumentNullException(SerializationInfo info, StreamingContext context);

        public static void ThrowIfNull(object argument, string paramName = null);
        [CLSCompliant(False)]
        public static void ThrowIfNull(void* argument, string paramName = null);
    }
}

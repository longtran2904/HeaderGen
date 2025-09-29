#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    public class COMException : ExternalException
    {

        public COMException();
        public COMException(string message);
        public COMException(string message, Exception inner);
        public COMException(string message, int errorCode);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected COMException(SerializationInfo info, StreamingContext context);

        public override string ToString();
    }
}

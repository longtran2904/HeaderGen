#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.IO
{
    public class IOException : SystemException
    {

        public IOException();
        public IOException(string message);
        public IOException(string message, int hresult);
        public IOException(string message, Exception innerException);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected IOException(SerializationInfo info, StreamingContext context);
    }
}

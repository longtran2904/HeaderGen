#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.IO
{
    public class FileNotFoundException : IOException
    {
        public FileNotFoundException();
        public FileNotFoundException(string message);
        public FileNotFoundException(string message, Exception innerException);
        public FileNotFoundException(string message, string fileName);
        public FileNotFoundException(string message, string fileName, Exception innerException);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected FileNotFoundException(SerializationInfo info, StreamingContext context);

        public override string Message { get; }
        public string FileName { get; }
        public string FusionLog { get; }

        public override string ToString();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}

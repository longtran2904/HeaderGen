#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public class BadImageFormatException : SystemException
    {
        public BadImageFormatException();
        public BadImageFormatException(string message);
        public BadImageFormatException(string message, Exception inner);
        public BadImageFormatException(string message, string fileName);
        public BadImageFormatException(string message, string fileName, Exception inner);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected BadImageFormatException(SerializationInfo info, StreamingContext context);

        public override string Message { get; }
        public string FileName { get; }
        public string FusionLog { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override string ToString();
    }
}

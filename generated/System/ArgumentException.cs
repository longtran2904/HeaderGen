#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public class ArgumentException : SystemException
    {

        public ArgumentException();
        public ArgumentException(string message);
        public ArgumentException(string message, Exception innerException);
        public ArgumentException(string message, string paramName, Exception innerException);
        public ArgumentException(string message, string paramName);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ArgumentException(SerializationInfo info, StreamingContext context);

        public override string Message { get; }
        public virtual string ParamName { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public static void ThrowIfNullOrEmpty(string argument, string paramName = null);
        public static void ThrowIfNullOrWhiteSpace(string argument, string paramName = null);
    }
}

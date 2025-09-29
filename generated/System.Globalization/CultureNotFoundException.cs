#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Globalization
{
    public class CultureNotFoundException : ArgumentException
    {

        public CultureNotFoundException();
        public CultureNotFoundException(string message);
        public CultureNotFoundException(string paramName, string message);
        public CultureNotFoundException(string message, Exception innerException);
        public CultureNotFoundException(string paramName, string invalidCultureName, string message);
        public CultureNotFoundException(string message, string invalidCultureName, Exception innerException);
        public CultureNotFoundException(string message, int invalidCultureId, Exception innerException);
        public CultureNotFoundException(string paramName, int invalidCultureId, string message);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected CultureNotFoundException(SerializationInfo info, StreamingContext context);

        public virtual int? InvalidCultureId { get; }
        public virtual string InvalidCultureName { get; }
        public override string Message { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    public class CannotUnloadAppDomainException : SystemException
    {

        public CannotUnloadAppDomainException();
        public CannotUnloadAppDomainException(string message);
        public CannotUnloadAppDomainException(string message, Exception innerException);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context);
    }
}

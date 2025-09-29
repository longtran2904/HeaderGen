#region System.Security.Principal.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.Principal.Windows.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Security.Principal
{
    public sealed class IdentityNotMappedException : SystemException
    {
        public IdentityNotMappedException();
        public IdentityNotMappedException(string message);
        public IdentityNotMappedException(string message, Exception inner);

        public IdentityReferenceCollection UnmappedIdentities { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext);
    }
}

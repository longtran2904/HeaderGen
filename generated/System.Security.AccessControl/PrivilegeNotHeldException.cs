#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Security.AccessControl
{
    public sealed class PrivilegeNotHeldException : UnauthorizedAccessException
    {
        public PrivilegeNotHeldException();
        public PrivilegeNotHeldException(string privilege);
        public PrivilegeNotHeldException(string privilege, Exception inner);

        public string PrivilegeName { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}

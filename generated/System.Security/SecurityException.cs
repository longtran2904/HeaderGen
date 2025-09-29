#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace System.Security
{
    public class SecurityException : SystemException
    {

        public SecurityException();
        public SecurityException(string message);
        public SecurityException(string message, Exception inner);
        public SecurityException(string message, Type type);
        public SecurityException(string message, Type type, string state);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected SecurityException(SerializationInfo info, StreamingContext context);

        public object Demanded { get; set; }
        public object DenySetInstance { get; set; }
        public AssemblyName FailedAssemblyInfo { get; set; }
        public string GrantedSet { get; set; }
        public MethodInfo Method { get; set; }
        public string PermissionState { get; set; }
        public Type PermissionType { get; set; }
        public object PermitOnlySetInstance { get; set; }
        public string RefusedSet { get; set; }
        public string Url { get; set; }

        public override string ToString();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}

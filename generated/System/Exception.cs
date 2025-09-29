#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace System
{
    public class Exception : ISerializable
    {
        public Exception();
        public Exception(string message);
        public Exception(string message, Exception innerException);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected Exception(SerializationInfo info, StreamingContext context);

        public MethodBase TargetSite { get; }
        public virtual string Message { get; }
        public virtual IDictionary Data { get; }
        public Exception InnerException { get; }
        public virtual string HelpLink { get; set; }
        public virtual string Source { get; set; }
        public int HResult { get; set; }
        public virtual string StackTrace { get; }

        [Obsolete("BinaryFormatter serialization is obsolete and should not be used. See https://aka.ms/binaryformatter for more information.", DiagnosticId = "SYSLIB0011", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected event EventHandler<SafeSerializationEventArgs> SerializeObjectState;

        public virtual Exception GetBaseException();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
        public override string ToString();
        public Type GetType();
    }
}

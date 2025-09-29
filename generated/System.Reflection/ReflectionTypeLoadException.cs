#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Reflection
{
    public sealed class ReflectionTypeLoadException : SystemException
    {

        public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions);
        public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions, string message);

        public Type[] Types { get; }
        public Exception[] LoaderExceptions { get; }
        public override string Message { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override string ToString();
    }
}

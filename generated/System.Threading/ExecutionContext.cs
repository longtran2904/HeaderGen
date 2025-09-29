#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Threading
{
    public sealed class ExecutionContext : IDisposable, ISerializable
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public static ExecutionContext Capture();
        public static AsyncFlowControl SuppressFlow();
        public static void RestoreFlow();
        public static bool IsFlowSuppressed();
        public static void Run(ExecutionContext executionContext, ContextCallback callback, object state);
        public static void Restore(ExecutionContext executionContext);
        public ExecutionContext CreateCopy();
        public void Dispose();
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Threading.Tasks
{
    public class TaskCanceledException : OperationCanceledException
    {

        public TaskCanceledException();
        public TaskCanceledException(string message);
        public TaskCanceledException(string message, Exception innerException);
        public TaskCanceledException(string message, Exception innerException, CancellationToken token);
        public TaskCanceledException(Task task);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected TaskCanceledException(SerializationInfo info, StreamingContext context);

        public Task Task { get; }
    }
}

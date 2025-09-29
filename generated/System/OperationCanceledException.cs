#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
    public class OperationCanceledException : SystemException
    {

        public OperationCanceledException();
        public OperationCanceledException(string message);
        public OperationCanceledException(string message, Exception innerException);
        public OperationCanceledException(CancellationToken token);
        public OperationCanceledException(string message, CancellationToken token);
        public OperationCanceledException(string message, Exception innerException, CancellationToken token);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected OperationCanceledException(SerializationInfo info, StreamingContext context);

        public CancellationToken CancellationToken { get; }
    }
}

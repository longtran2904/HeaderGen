#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using Microsoft.Win32.SafeHandles;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Pipes
{
    public sealed class NamedPipeServerStream : PipeStream
    {

        public const int MaxAllowedServerInstances = -1;

        public NamedPipeServerStream(string pipeName);
        public NamedPipeServerStream(string pipeName, PipeDirection direction);
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances);
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode);
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options);
        public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize);
        public NamedPipeServerStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle);

        ~NamedPipeServerStream();

        public Task WaitForConnectionAsync();
        public IAsyncResult BeginWaitForConnection(AsyncCallback callback, object state);
        public void EndWaitForConnection(IAsyncResult asyncResult);
        protected override void Dispose(bool disposing);
        public void WaitForConnection();
        public Task WaitForConnectionAsync(CancellationToken cancellationToken);
        public void Disconnect();
        public string GetImpersonationUserName();
        public void RunAsClient(PipeStreamImpersonationWorker impersonationWorker);
    }
}

#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using Microsoft.Win32.SafeHandles;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Pipes
{
    public sealed class NamedPipeClientStream : PipeStream
    {

        public NamedPipeClientStream(string pipeName);
        public NamedPipeClientStream(string serverName, string pipeName);
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction);
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options);
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel);
        public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability);
        public NamedPipeClientStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle);

        ~NamedPipeClientStream();

        [SupportedOSPlatform("windows")]
        public int NumberOfServerInstances { get; }

        public void Connect();
        public void Connect(int timeout);
        public void Connect(TimeSpan timeout);
        public Task ConnectAsync();
        public Task ConnectAsync(int timeout);
        public Task ConnectAsync(CancellationToken cancellationToken);
        public Task ConnectAsync(int timeout, CancellationToken cancellationToken);
        public Task ConnectAsync(TimeSpan timeout, CancellationToken cancellationToken = null);
        protected internal override void CheckPipePropertyOperations();
    }
}

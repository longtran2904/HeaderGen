#region System.IO.Pipes, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.IO.Pipes.dll
#endregion

using Microsoft.Win32.SafeHandles;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO.Pipes
{
    public abstract class PipeStream : Stream
    {

        protected PipeStream(PipeDirection direction, int bufferSize);
        protected PipeStream(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize);

        public bool IsConnected { get; protected set; }
        public bool IsAsync { get; }
        public bool IsMessageComplete { get; }
        public SafePipeHandle SafePipeHandle { get; }
        protected bool IsHandleExposed { get; }
        public override bool CanRead { get; }
        public override bool CanWrite { get; }
        public override bool CanSeek { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        public virtual PipeTransmissionMode TransmissionMode { get; }
        public virtual int InBufferSize { get; }
        public virtual int OutBufferSize { get; }
        public virtual PipeTransmissionMode ReadMode { get; set; }

        protected void InitializeHandle(SafePipeHandle handle, bool isExposed, bool isAsync);
        public override int ReadByte();
        public override void WriteByte(byte value);
        public override void Flush();
        public override Task FlushAsync(CancellationToken cancellationToken);
        protected override void Dispose(bool disposing);
        public override void SetLength(long value);
        public override long Seek(long offset, SeekOrigin origin);
        protected internal virtual void CheckPipePropertyOperations();
        protected internal void CheckReadOperations();
        protected internal void CheckWriteOperations();
        public override int Read(byte[] buffer, int offset, int count);
        public override int Read(Span<byte> buffer);
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null);
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public override int EndRead(IAsyncResult asyncResult);
        public override void Write(byte[] buffer, int offset, int count);
        public override void Write(ReadOnlySpan<byte> buffer);
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null);
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public override void EndWrite(IAsyncResult asyncResult);
        [SupportedOSPlatform("windows")]
        public void WaitForPipeDrain();
    }
}

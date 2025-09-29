#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public sealed class BufferedStream : Stream
    {
        public BufferedStream(Stream stream);
        public BufferedStream(Stream stream, int bufferSize);

        public Stream UnderlyingStream { get; }
        public int BufferSize { get; }
        public override bool CanRead { get; }
        public override bool CanWrite { get; }
        public override bool CanSeek { get; }
        public override long Length { get; }
        public override long Position { get; set; }

        protected override void Dispose(bool disposing);
        public async override ValueTask DisposeAsync();
        public override void Flush();
        public override Task FlushAsync(CancellationToken cancellationToken);
        public override int Read(byte[] buffer, int offset, int count);
        public override int Read(Span<byte> destination);
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null);
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public override int EndRead(IAsyncResult asyncResult);
        public override int ReadByte();
        public override void Write(byte[] buffer, int offset, int count);
        public override void Write(ReadOnlySpan<byte> buffer);
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null);
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public override void EndWrite(IAsyncResult asyncResult);
        public override void WriteByte(byte value);
        public override long Seek(long offset, SeekOrigin origin);
        public override void SetLength(long value);
        public override void CopyTo(Stream destination, int bufferSize);
        public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);
    }
}

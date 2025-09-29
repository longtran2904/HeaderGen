#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public class MemoryStream : Stream
    {

        public MemoryStream();
        public MemoryStream(int capacity);
        public MemoryStream(byte[] buffer);
        public MemoryStream(byte[] buffer, bool writable);
        public MemoryStream(byte[] buffer, int index, int count);
        public MemoryStream(byte[] buffer, int index, int count, bool writable);
        public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible);

        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public virtual int Capacity { get; set; }
        public override long Length { get; }
        public override long Position { get; set; }

        protected override void Dispose(bool disposing);
        public override void Flush();
        public override Task FlushAsync(CancellationToken cancellationToken);
        public virtual byte[] GetBuffer();
        public virtual bool TryGetBuffer(out ArraySegment<byte> buffer);
        public override int Read(byte[] buffer, int offset, int count);
        public override int Read(Span<byte> buffer);
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null);
        public override int ReadByte();
        public override void CopyTo(Stream destination, int bufferSize);
        public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);
        public override long Seek(long offset, SeekOrigin loc);
        public override void SetLength(long value);
        public virtual byte[] ToArray();
        public override void Write(byte[] buffer, int offset, int count);
        public override void Write(ReadOnlySpan<byte> buffer);
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null);
        public override void WriteByte(byte value);
        public virtual void WriteTo(Stream stream);
    }
}

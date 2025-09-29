#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public class UnmanagedMemoryStream : Stream
    {

        protected UnmanagedMemoryStream();
        public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length);
        public UnmanagedMemoryStream(SafeBuffer buffer, long offset, long length, FileAccess access);
        [CLSCompliant(False)]
        public UnmanagedMemoryStream(byte* pointer, long length);
        [CLSCompliant(False)]
        public UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access);

        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public long Capacity { get; }
        public override long Position { get; set; }
        [CLSCompliant(False)]
        public byte* PositionPointer { get; set; }

        protected void Initialize(SafeBuffer buffer, long offset, long length, FileAccess access);
        [CLSCompliant(False)]
        protected void Initialize(byte* pointer, long length, long capacity, FileAccess access);
        protected override void Dispose(bool disposing);
        public override void Flush();
        public override Task FlushAsync(CancellationToken cancellationToken);
        public override int Read(byte[] buffer, int offset, int count);
        public override int Read(Span<byte> buffer);
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null);
        public override int ReadByte();
        public override long Seek(long offset, SeekOrigin loc);
        public override void SetLength(long value);
        public override void Write(byte[] buffer, int offset, int count);
        public override void Write(ReadOnlySpan<byte> buffer);
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null);
        public override void WriteByte(byte value);
    }
}

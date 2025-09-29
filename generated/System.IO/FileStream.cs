#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public class FileStream : Stream
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access) instead.")]
        public FileStream(nint handle, FileAccess access);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access) and optionally make a new SafeFileHandle with ownsHandle=false if needed instead.")]
        public FileStream(nint handle, FileAccess access, bool ownsHandle);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) and optionally make a new SafeFileHandle with ownsHandle=false if needed instead.")]
        public FileStream(nint handle, FileAccess access, bool ownsHandle, int bufferSize);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This constructor has been deprecated. Use FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) and optionally make a new SafeFileHandle with ownsHandle=false if needed instead.")]
        public FileStream(nint handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync);
        public FileStream(SafeFileHandle handle, FileAccess access);
        public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize);
        public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync);
        public FileStream(string path, FileMode mode);
        public FileStream(string path, FileMode mode, FileAccess access);
        public FileStream(string path, FileMode mode, FileAccess access, FileShare share);
        public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize);
        public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync);
        public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options);
        public FileStream(string path, FileStreamOptions options);

        ~FileStream();

        [Obsolete("FileStream.Handle has been deprecated. Use FileStream's SafeFileHandle property instead.")]
        public virtual nint Handle { get; }
        public override bool CanRead { get; }
        public override bool CanWrite { get; }
        public virtual SafeFileHandle SafeFileHandle { get; }
        public virtual string Name { get; }
        public virtual bool IsAsync { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        public override bool CanSeek { get; }

        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("macos")]
        [UnsupportedOSPlatform("tvos")]
        [UnsupportedOSPlatform("freebsd")]
        public virtual void Lock(long position, long length);
        [UnsupportedOSPlatform("ios")]
        [UnsupportedOSPlatform("macos")]
        [UnsupportedOSPlatform("tvos")]
        [UnsupportedOSPlatform("freebsd")]
        public virtual void Unlock(long position, long length);
        public override Task FlushAsync(CancellationToken cancellationToken);
        public override int Read(byte[] buffer, int offset, int count);
        public override int Read(Span<byte> buffer);
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null);
        public override void Write(byte[] buffer, int offset, int count);
        public override void Write(ReadOnlySpan<byte> buffer);
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null);
        public override void Flush();
        public virtual void Flush(bool flushToDisk);
        public override void SetLength(long value);
        public override int ReadByte();
        public override void WriteByte(byte value);
        protected override void Dispose(bool disposing);
        public async override ValueTask DisposeAsync();
        public override void CopyTo(Stream destination, int bufferSize);
        public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public override int EndRead(IAsyncResult asyncResult);
        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public override void EndWrite(IAsyncResult asyncResult);
        public override long Seek(long offset, SeekOrigin origin);
    }
}

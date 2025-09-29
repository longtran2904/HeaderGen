#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public abstract class Stream : MarshalByRefObject, IAsyncDisposable, IDisposable
    {

        public static readonly Stream Null;

        protected Stream();

        public abstract bool CanRead { get; }
        public abstract bool CanWrite { get; }
        public abstract bool CanSeek { get; }
        public virtual bool CanTimeout { get; }
        public abstract long Length { get; }
        public abstract long Position { get; set; }
        public virtual int ReadTimeout { get; set; }
        public virtual int WriteTimeout { get; set; }

        public void CopyTo(Stream destination);
        public virtual void CopyTo(Stream destination, int bufferSize);
        public Task CopyToAsync(Stream destination);
        public Task CopyToAsync(Stream destination, int bufferSize);
        public Task CopyToAsync(Stream destination, CancellationToken cancellationToken);
        public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken);
        public void Dispose();
        public virtual void Close();
        protected virtual void Dispose(bool disposing);
        public virtual ValueTask DisposeAsync();
        public abstract void Flush();
        public Task FlushAsync();
        public virtual Task FlushAsync(CancellationToken cancellationToken);
        [Obsolete("CreateWaitHandle has been deprecated. Use the ManualResetEvent(false) constructor instead.")]
        protected virtual WaitHandle CreateWaitHandle();
        public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public virtual int EndRead(IAsyncResult asyncResult);
        public Task<int> ReadAsync(byte[] buffer, int offset, int count);
        public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = null);
        public ValueTask ReadExactlyAsync(Memory<byte> buffer, CancellationToken cancellationToken = null);
        public ValueTask ReadExactlyAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken = null);
        public ValueTask<int> ReadAtLeastAsync(Memory<byte> buffer, int minimumBytes, bool throwOnEndOfStream = True, CancellationToken cancellationToken = null);
        public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
        public virtual void EndWrite(IAsyncResult asyncResult);
        public Task WriteAsync(byte[] buffer, int offset, int count);
        public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = null);
        public abstract long Seek(long offset, SeekOrigin origin);
        public abstract void SetLength(long value);
        public abstract int Read(byte[] buffer, int offset, int count);
        public virtual int Read(Span<byte> buffer);
        public virtual int ReadByte();
        public void ReadExactly(Span<byte> buffer);
        public void ReadExactly(byte[] buffer, int offset, int count);
        public int ReadAtLeast(Span<byte> buffer, int minimumBytes, bool throwOnEndOfStream = True);
        public abstract void Write(byte[] buffer, int offset, int count);
        public virtual void Write(ReadOnlySpan<byte> buffer);
        public virtual void WriteByte(byte value);
        public static Stream Synchronized(Stream stream);
        [Obsolete("Do not call or override this method.")]
        protected virtual void ObjectInvariant();
        protected static void ValidateBufferArguments(byte[] buffer, int offset, int count);
        protected static void ValidateCopyToArguments(Stream destination, int bufferSize);
    }
}

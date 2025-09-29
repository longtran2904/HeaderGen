#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.IO;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public abstract class HttpContent : IDisposable
    {
        protected HttpContent();

        public HttpContentHeaders Headers { get; }

        public Task<string> ReadAsStringAsync();
        public Task<string> ReadAsStringAsync(CancellationToken cancellationToken);
        public Task<byte[]> ReadAsByteArrayAsync();
        public Task<byte[]> ReadAsByteArrayAsync(CancellationToken cancellationToken);
        public Stream ReadAsStream();
        public Stream ReadAsStream(CancellationToken cancellationToken);
        public Task<Stream> ReadAsStreamAsync();
        public Task<Stream> ReadAsStreamAsync(CancellationToken cancellationToken);
        protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);
        protected virtual void SerializeToStream(Stream stream, TransportContext context, CancellationToken cancellationToken);
        protected virtual Task SerializeToStreamAsync(Stream stream, TransportContext context, CancellationToken cancellationToken);
        public void CopyTo(Stream stream, TransportContext context, CancellationToken cancellationToken);
        public Task CopyToAsync(Stream stream);
        public Task CopyToAsync(Stream stream, CancellationToken cancellationToken);
        public Task CopyToAsync(Stream stream, TransportContext context);
        public Task CopyToAsync(Stream stream, TransportContext context, CancellationToken cancellationToken);
        public Task LoadIntoBufferAsync();
        public Task LoadIntoBufferAsync(long maxBufferSize);
        protected virtual Stream CreateContentReadStream(CancellationToken cancellationToken);
        protected virtual Task<Stream> CreateContentReadStreamAsync();
        protected virtual Task<Stream> CreateContentReadStreamAsync(CancellationToken cancellationToken);
        protected internal abstract bool TryComputeLength(out long length);
        protected virtual void Dispose(bool disposing);
        public void Dispose();
    }
}

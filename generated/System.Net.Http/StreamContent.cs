#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public class StreamContent : HttpContent
    {

        public StreamContent(Stream content);
        public StreamContent(Stream content, int bufferSize);

        protected override void SerializeToStream(Stream stream, TransportContext context, CancellationToken cancellationToken);
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context);
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context, CancellationToken cancellationToken);
        protected internal override bool TryComputeLength(out long length);
        protected override void Dispose(bool disposing);
        protected override Stream CreateContentReadStream(CancellationToken cancellationToken);
        protected override Task<Stream> CreateContentReadStreamAsync();
    }
}

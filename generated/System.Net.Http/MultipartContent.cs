#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public class MultipartContent : HttpContent, IEnumerable, IEnumerable<HttpContent>
    {

        public MultipartContent();
        public MultipartContent(string subtype);
        public MultipartContent(string subtype, string boundary);

        public HeaderEncodingSelector<HttpContent> HeaderEncodingSelector { get; set; }

        public virtual void Add(HttpContent content);
        protected override void Dispose(bool disposing);
        public IEnumerator<HttpContent> GetEnumerator();
        protected override void SerializeToStream(Stream stream, TransportContext context, CancellationToken cancellationToken);
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context);
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context, CancellationToken cancellationToken);
        protected override Stream CreateContentReadStream(CancellationToken cancellationToken);
        protected override Task<Stream> CreateContentReadStreamAsync();
        protected override Task<Stream> CreateContentReadStreamAsync(CancellationToken cancellationToken);
        protected internal override bool TryComputeLength(out long length);
    }
}

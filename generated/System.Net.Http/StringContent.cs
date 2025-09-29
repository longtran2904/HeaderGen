#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public class StringContent : ByteArrayContent
    {

        public StringContent(string content);
        public StringContent(string content, MediaTypeHeaderValue mediaType);
        public StringContent(string content, Encoding encoding);
        public StringContent(string content, Encoding encoding, string mediaType);
        public StringContent(string content, Encoding encoding, MediaTypeHeaderValue mediaType);

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context, CancellationToken cancellationToken);
    }
}

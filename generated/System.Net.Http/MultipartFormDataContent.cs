#region System.Net.Http, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Net.Http.dll
#endregion

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
    public class MultipartFormDataContent : MultipartContent
    {
        public MultipartFormDataContent();
        public MultipartFormDataContent(string boundary);

        public override void Add(HttpContent content);
        public void Add(HttpContent content, string name);
        public void Add(HttpContent content, string name, string fileName);
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context, CancellationToken cancellationToken);
    }
}

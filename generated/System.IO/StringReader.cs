#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public class StringReader : TextReader
    {
        public StringReader(string s);

        public override void Close();
        protected override void Dispose(bool disposing);
        public override int Peek();
        public override int Read();
        public override int Read(char[] buffer, int index, int count);
        public override int Read(Span<char> buffer);
        public override int ReadBlock(Span<char> buffer);
        public override string ReadToEnd();
        public override string ReadLine();
        public override Task<string> ReadLineAsync();
        public override ValueTask<string> ReadLineAsync(CancellationToken cancellationToken);
        public override Task<string> ReadToEndAsync();
        public override Task<string> ReadToEndAsync(CancellationToken cancellationToken);
        public override Task<int> ReadBlockAsync(char[] buffer, int index, int count);
        public override ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = null);
        public override Task<int> ReadAsync(char[] buffer, int index, int count);
        public override ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = null);
    }
}

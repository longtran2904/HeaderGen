#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public abstract class TextReader : MarshalByRefObject, IDisposable
    {
        public static readonly TextReader Null;

        protected TextReader();

        public virtual void Close();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public virtual int Peek();
        public virtual int Read();
        public virtual int Read(char[] buffer, int index, int count);
        public virtual int Read(Span<char> buffer);
        public virtual string ReadToEnd();
        public virtual int ReadBlock(char[] buffer, int index, int count);
        public virtual int ReadBlock(Span<char> buffer);
        public virtual string ReadLine();
        public virtual Task<string> ReadLineAsync();
        public virtual ValueTask<string> ReadLineAsync(CancellationToken cancellationToken);
        public virtual Task<string> ReadToEndAsync();
        public async virtual Task<string> ReadToEndAsync(CancellationToken cancellationToken);
        public virtual Task<int> ReadAsync(char[] buffer, int index, int count);
        public virtual ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = null);
        public virtual Task<int> ReadBlockAsync(char[] buffer, int index, int count);
        public virtual ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = null);
        public static TextReader Synchronized(TextReader reader);
    }
}

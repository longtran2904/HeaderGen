#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public class StreamWriter : TextWriter
    {

        public static readonly StreamWriter Null;

        public StreamWriter(Stream stream);
        public StreamWriter(Stream stream, Encoding encoding);
        public StreamWriter(Stream stream, Encoding encoding, int bufferSize);
        public StreamWriter(Stream stream, Encoding encoding = null, int bufferSize = -1, bool leaveOpen = False);
        public StreamWriter(string path);
        public StreamWriter(string path, bool append);
        public StreamWriter(string path, bool append, Encoding encoding);
        public StreamWriter(string path, bool append, Encoding encoding, int bufferSize);
        public StreamWriter(string path, FileStreamOptions options);
        public StreamWriter(string path, Encoding encoding, FileStreamOptions options);

        public virtual bool AutoFlush { get; set; }
        public virtual Stream BaseStream { get; }
        public override Encoding Encoding { get; }

        public override void Close();
        protected override void Dispose(bool disposing);
        public override ValueTask DisposeAsync();
        public override void Flush();
        public override void Write(char value);
        public override void Write(char[] buffer);
        public override void Write(char[] buffer, int index, int count);
        public override void Write(ReadOnlySpan<char> buffer);
        public override void Write(string value);
        public override void WriteLine(string value);
        public override void WriteLine(ReadOnlySpan<char> buffer);
        public override void Write(string format, object arg0);
        public override void Write(string format, object arg0, object arg1);
        public override void Write(string format, object arg0, object arg1, object arg2);
        public override void Write(string format, params object[] arg);
        public override void WriteLine(string format, object arg0);
        public override void WriteLine(string format, object arg0, object arg1);
        public override void WriteLine(string format, object arg0, object arg1, object arg2);
        public override void WriteLine(string format, params object[] arg);
        public override Task WriteAsync(char value);
        public override Task WriteAsync(string value);
        public override Task WriteAsync(char[] buffer, int index, int count);
        public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public override Task WriteLineAsync();
        public override Task WriteLineAsync(char value);
        public override Task WriteLineAsync(string value);
        public override Task WriteLineAsync(char[] buffer, int index, int count);
        public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public override Task FlushAsync();
        public override Task FlushAsync(CancellationToken cancellationToken);
    }
}

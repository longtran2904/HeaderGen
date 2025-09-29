#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public class StringWriter : TextWriter
    {
        public StringWriter();
        public StringWriter(IFormatProvider formatProvider);
        public StringWriter(StringBuilder sb);
        public StringWriter(StringBuilder sb, IFormatProvider formatProvider);

        public override Encoding Encoding { get; }

        public override void Close();
        protected override void Dispose(bool disposing);
        public virtual StringBuilder GetStringBuilder();
        public override void Write(char value);
        public override void Write(char[] buffer, int index, int count);
        public override void Write(ReadOnlySpan<char> buffer);
        public override void Write(string value);
        public override void Write(StringBuilder value);
        public override void WriteLine(ReadOnlySpan<char> buffer);
        public override void WriteLine(StringBuilder value);
        public override Task WriteAsync(char value);
        public override Task WriteAsync(string value);
        public override Task WriteAsync(char[] buffer, int index, int count);
        public override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public override Task WriteAsync(StringBuilder value, CancellationToken cancellationToken = null);
        public override Task WriteLineAsync(char value);
        public override Task WriteLineAsync(string value);
        public override Task WriteLineAsync(StringBuilder value, CancellationToken cancellationToken = null);
        public override Task WriteLineAsync(char[] buffer, int index, int count);
        public override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public override Task FlushAsync();
        public override string ToString();
    }
}

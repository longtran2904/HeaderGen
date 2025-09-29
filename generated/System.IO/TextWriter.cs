#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public abstract class TextWriter : MarshalByRefObject, IAsyncDisposable, IDisposable
    {
        protected char[] CoreNewLine;
        public static readonly TextWriter Null;

        protected TextWriter();
        protected TextWriter(IFormatProvider formatProvider);

        public virtual IFormatProvider FormatProvider { get; }
        public abstract Encoding Encoding { get; }
        public virtual string NewLine { get; set; }

        public virtual void Close();
        protected virtual void Dispose(bool disposing);
        public void Dispose();
        public virtual ValueTask DisposeAsync();
        public virtual void Flush();
        public virtual void Write(char value);
        public virtual void Write(char[] buffer);
        public virtual void Write(char[] buffer, int index, int count);
        public virtual void Write(ReadOnlySpan<char> buffer);
        public virtual void Write(bool value);
        public virtual void Write(int value);
        [CLSCompliant(False)]
        public virtual void Write(uint value);
        public virtual void Write(long value);
        [CLSCompliant(False)]
        public virtual void Write(ulong value);
        public virtual void Write(float value);
        public virtual void Write(double value);
        public virtual void Write(decimal value);
        public virtual void Write(string value);
        public virtual void Write(object value);
        public virtual void Write(StringBuilder value);
        public virtual void Write(string format, object arg0);
        public virtual void Write(string format, object arg0, object arg1);
        public virtual void Write(string format, object arg0, object arg1, object arg2);
        public virtual void Write(string format, params object[] arg);
        public virtual void WriteLine();
        public virtual void WriteLine(char value);
        public virtual void WriteLine(char[] buffer);
        public virtual void WriteLine(char[] buffer, int index, int count);
        public virtual void WriteLine(ReadOnlySpan<char> buffer);
        public virtual void WriteLine(bool value);
        public virtual void WriteLine(int value);
        [CLSCompliant(False)]
        public virtual void WriteLine(uint value);
        public virtual void WriteLine(long value);
        [CLSCompliant(False)]
        public virtual void WriteLine(ulong value);
        public virtual void WriteLine(float value);
        public virtual void WriteLine(double value);
        public virtual void WriteLine(decimal value);
        public virtual void WriteLine(string value);
        public virtual void WriteLine(StringBuilder value);
        public virtual void WriteLine(object value);
        public virtual void WriteLine(string format, object arg0);
        public virtual void WriteLine(string format, object arg0, object arg1);
        public virtual void WriteLine(string format, object arg0, object arg1, object arg2);
        public virtual void WriteLine(string format, params object[] arg);
        public virtual Task WriteAsync(char value);
        public virtual Task WriteAsync(string value);
        public virtual Task WriteAsync(StringBuilder value, CancellationToken cancellationToken = null);
        public Task WriteAsync(char[] buffer);
        public virtual Task WriteAsync(char[] buffer, int index, int count);
        public virtual Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public virtual Task WriteLineAsync(char value);
        public virtual Task WriteLineAsync(string value);
        public virtual Task WriteLineAsync(StringBuilder value, CancellationToken cancellationToken = null);
        public Task WriteLineAsync(char[] buffer);
        public virtual Task WriteLineAsync(char[] buffer, int index, int count);
        public virtual Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public virtual Task WriteLineAsync();
        public virtual Task FlushAsync();
        public virtual Task FlushAsync(CancellationToken cancellationToken);
        public static TextWriter Synchronized(TextWriter writer);
    }
}

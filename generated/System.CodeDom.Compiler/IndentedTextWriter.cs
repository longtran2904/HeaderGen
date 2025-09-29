#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.CodeDom.Compiler
{
    public class IndentedTextWriter : TextWriter
    {

        public const string DefaultTabString = "    ";

        public IndentedTextWriter(TextWriter writer);
        public IndentedTextWriter(TextWriter writer, string tabString);

        public override Encoding Encoding { get; }
        public override string NewLine { get; set; }
        public int Indent { get; set; }
        public TextWriter InnerWriter { get; }

        public override void Close();
        public override ValueTask DisposeAsync();
        public override void Flush();
        public override Task FlushAsync();
        public override Task FlushAsync(CancellationToken cancellationToken);
        protected virtual void OutputTabs();
        protected async virtual Task OutputTabsAsync();
        public override void Write(string s);
        public override void Write(bool value);
        public override void Write(char value);
        public override void Write(char[] buffer);
        public override void Write(char[] buffer, int index, int count);
        public override void Write(double value);
        public override void Write(float value);
        public override void Write(int value);
        public override void Write(long value);
        public override void Write(object value);
        public override void Write(string format, object arg0);
        public override void Write(string format, object arg0, object arg1);
        public override void Write(string format, params object[] arg);
        public async override Task WriteAsync(char value);
        public async override Task WriteAsync(char[] buffer, int index, int count);
        public async override Task WriteAsync(string value);
        public async override Task WriteAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public async override Task WriteAsync(StringBuilder value, CancellationToken cancellationToken = null);
        public void WriteLineNoTabs(string s);
        public Task WriteLineNoTabsAsync(string s);
        public override void WriteLine(string s);
        public override void WriteLine();
        public override void WriteLine(bool value);
        public override void WriteLine(char value);
        public override void WriteLine(char[] buffer);
        public override void WriteLine(char[] buffer, int index, int count);
        public override void WriteLine(double value);
        public override void WriteLine(float value);
        public override void WriteLine(int value);
        public override void WriteLine(long value);
        public override void WriteLine(object value);
        public override void WriteLine(string format, object arg0);
        public override void WriteLine(string format, object arg0, object arg1);
        public override void WriteLine(string format, params object[] arg);
        [CLSCompliant(False)]
        public override void WriteLine(uint value);
        public async override Task WriteLineAsync();
        public async override Task WriteLineAsync(char value);
        public async override Task WriteLineAsync(char[] buffer, int index, int count);
        public async override Task WriteLineAsync(string value);
        public async override Task WriteLineAsync(ReadOnlyMemory<char> buffer, CancellationToken cancellationToken = null);
        public async override Task WriteLineAsync(StringBuilder value, CancellationToken cancellationToken = null);
    }
}

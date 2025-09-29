#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
    public class BinaryWriter : IAsyncDisposable, IDisposable
    {
        protected Stream OutStream;
        public static readonly BinaryWriter Null;

        protected BinaryWriter();
        public BinaryWriter(Stream output);
        public BinaryWriter(Stream output, Encoding encoding);
        public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen);

        public virtual Stream BaseStream { get; }

        public virtual void Close();
        protected virtual void Dispose(bool disposing);
        public void Dispose();
        public virtual ValueTask DisposeAsync();
        public virtual void Flush();
        public virtual long Seek(int offset, SeekOrigin origin);
        public virtual void Write(bool value);
        public virtual void Write(byte value);
        [CLSCompliant(False)]
        public virtual void Write(sbyte value);
        public virtual void Write(byte[] buffer);
        public virtual void Write(byte[] buffer, int index, int count);
        public virtual void Write(char ch);
        public virtual void Write(char[] chars);
        public virtual void Write(char[] chars, int index, int count);
        public virtual void Write(double value);
        public virtual void Write(decimal value);
        public virtual void Write(short value);
        [CLSCompliant(False)]
        public virtual void Write(ushort value);
        public virtual void Write(int value);
        [CLSCompliant(False)]
        public virtual void Write(uint value);
        public virtual void Write(long value);
        [CLSCompliant(False)]
        public virtual void Write(ulong value);
        public virtual void Write(float value);
        public virtual void Write(Half value);
        public virtual void Write(string value);
        public virtual void Write(ReadOnlySpan<byte> buffer);
        public virtual void Write(ReadOnlySpan<char> chars);
        public void Write7BitEncodedInt(int value);
        public void Write7BitEncodedInt64(long value);
    }
}

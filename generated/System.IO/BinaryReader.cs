#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Text;

namespace System.IO
{
    public class BinaryReader : IDisposable
    {

        public BinaryReader(Stream input);
        public BinaryReader(Stream input, Encoding encoding);
        public BinaryReader(Stream input, Encoding encoding, bool leaveOpen);

        public virtual Stream BaseStream { get; }

        protected virtual void Dispose(bool disposing);
        public void Dispose();
        public virtual void Close();
        public virtual int PeekChar();
        public virtual int Read();
        public virtual byte ReadByte();
        [CLSCompliant(False)]
        public virtual sbyte ReadSByte();
        public virtual bool ReadBoolean();
        public virtual char ReadChar();
        public virtual short ReadInt16();
        [CLSCompliant(False)]
        public virtual ushort ReadUInt16();
        public virtual int ReadInt32();
        [CLSCompliant(False)]
        public virtual uint ReadUInt32();
        public virtual long ReadInt64();
        [CLSCompliant(False)]
        public virtual ulong ReadUInt64();
        public virtual Half ReadHalf();
        public virtual float ReadSingle();
        public virtual double ReadDouble();
        public virtual decimal ReadDecimal();
        public virtual string ReadString();
        public virtual int Read(char[] buffer, int index, int count);
        public virtual int Read(Span<char> buffer);
        public virtual char[] ReadChars(int count);
        public virtual int Read(byte[] buffer, int index, int count);
        public virtual int Read(Span<byte> buffer);
        public virtual byte[] ReadBytes(int count);
        protected virtual void FillBuffer(int numBytes);
        public int Read7BitEncodedInt();
        public long Read7BitEncodedInt64();
    }
}

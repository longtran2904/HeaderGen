#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;

namespace System.IO
{
    public class UnmanagedMemoryAccessor : IDisposable
    {
        protected UnmanagedMemoryAccessor();
        public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity);
        public UnmanagedMemoryAccessor(SafeBuffer buffer, long offset, long capacity, FileAccess access);

        public long Capacity { get; }
        public bool CanRead { get; }
        public bool CanWrite { get; }
        protected bool IsOpen { get; }

        protected void Initialize(SafeBuffer buffer, long offset, long capacity, FileAccess access);
        protected virtual void Dispose(bool disposing);
        public void Dispose();
        public bool ReadBoolean(long position);
        public byte ReadByte(long position);
        public char ReadChar(long position);
        public short ReadInt16(long position);
        public int ReadInt32(long position);
        public long ReadInt64(long position);
        public decimal ReadDecimal(long position);
        public float ReadSingle(long position);
        public double ReadDouble(long position);
        [CLSCompliant(False)]
        public sbyte ReadSByte(long position);
        [CLSCompliant(False)]
        public ushort ReadUInt16(long position);
        [CLSCompliant(False)]
        public uint ReadUInt32(long position);
        [CLSCompliant(False)]
        public ulong ReadUInt64(long position);
        public void Read<T>(long position, out T structure) where T : struct;
        public int ReadArray<T>(long position, T[] array, int offset, int count) where T : struct;
        public void Write(long position, bool value);
        public void Write(long position, byte value);
        public void Write(long position, char value);
        public void Write(long position, short value);
        public void Write(long position, int value);
        public void Write(long position, long value);
        public void Write(long position, decimal value);
        public void Write(long position, float value);
        public void Write(long position, double value);
        [CLSCompliant(False)]
        public void Write(long position, sbyte value);
        [CLSCompliant(False)]
        public void Write(long position, ushort value);
        [CLSCompliant(False)]
        public void Write(long position, uint value);
        [CLSCompliant(False)]
        public void Write(long position, ulong value);
        public void Write<T>(long position, ref T structure) where T : struct;
        public void WriteArray<T>(long position, T[] array, int offset, int count) where T : struct;
    }
}

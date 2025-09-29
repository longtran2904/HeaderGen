#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
    public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
    {
        protected SafeBuffer(bool ownsHandle);

        [CLSCompliant(False)]
        public ulong ByteLength { get; }

        [CLSCompliant(False)]
        public void Initialize(ulong numBytes);
        [CLSCompliant(False)]
        public void Initialize(uint numElements, uint sizeOfEachElement);
        [CLSCompliant(False)]
        public void Initialize<T>(uint numElements) where T : struct;
        [CLSCompliant(False)]
        public void AcquirePointer(ref byte* pointer);
        public void ReleasePointer();
        [CLSCompliant(False)]
        public T Read<T>(ulong byteOffset) where T : struct;
        [CLSCompliant(False)]
        public void ReadArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct;
        [CLSCompliant(False)]
        public void ReadSpan<T>(ulong byteOffset, Span<T> buffer) where T : struct;
        [CLSCompliant(False)]
        public void Write<T>(ulong byteOffset, T value) where T : struct;
        [CLSCompliant(False)]
        public void WriteArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct;
        [CLSCompliant(False)]
        public void WriteSpan<T>(ulong byteOffset, ReadOnlySpan<T> data) where T : struct;
    }
}

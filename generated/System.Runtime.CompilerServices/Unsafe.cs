#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    public static class Unsafe
    {
        [CLSCompliant(False)]
        public static void* AsPointer<T>(ref T value);
        public static int SizeOf<T>();
        public static T As<T>(object o) where T : class;
        public static ref TTo As<TFrom, TTo>(ref TFrom source);
        public static ref T Add<T>(ref T source, int elementOffset);
        public static ref T Add<T>(ref T source, nint elementOffset);
        [CLSCompliant(False)]
        public static void* Add<T>(void* source, int elementOffset);
        [CLSCompliant(False)]
        public static ref T Add<T>(ref T source, nuint elementOffset);
        [CLSCompliant(False)]
        public static ref T AddByteOffset<T>(ref T source, nuint byteOffset);
        public static bool AreSame<T>(in T left, in T right);
        public static TTo BitCast<TFrom, TTo>(TFrom source) where TFrom : struct where TTo : struct;
        [CLSCompliant(False)]
        public static void Copy<T>(void* destination, in T source);
        [CLSCompliant(False)]
        public static void Copy<T>(ref T destination, void* source);
        [CLSCompliant(False)]
        public static void CopyBlock(void* destination, void* source, uint byteCount);
        [CLSCompliant(False)]
        public static void CopyBlock(ref byte destination, in byte source, uint byteCount);
        [CLSCompliant(False)]
        public static void CopyBlockUnaligned(void* destination, void* source, uint byteCount);
        [CLSCompliant(False)]
        public static void CopyBlockUnaligned(ref byte destination, in byte source, uint byteCount);
        public static bool IsAddressGreaterThan<T>(in T left, in T right);
        public static bool IsAddressLessThan<T>(in T left, in T right);
        [CLSCompliant(False)]
        public static void InitBlock(void* startAddress, byte value, uint byteCount);
        [CLSCompliant(False)]
        public static void InitBlock(ref byte startAddress, byte value, uint byteCount);
        [CLSCompliant(False)]
        public static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount);
        [CLSCompliant(False)]
        public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount);
        [CLSCompliant(False)]
        public static T ReadUnaligned<T>(void* source);
        public static T ReadUnaligned<T>(in byte source);
        [CLSCompliant(False)]
        public static void WriteUnaligned<T>(void* destination, T value);
        public static void WriteUnaligned<T>(ref byte destination, T value);
        public static ref T AddByteOffset<T>(ref T source, nint byteOffset);
        [CLSCompliant(False)]
        public static T Read<T>(void* source);
        [CLSCompliant(False)]
        public static void Write<T>(void* destination, T value);
        [CLSCompliant(False)]
        public static ref T AsRef<T>(void* source);
        public static ref T AsRef<T>(scoped in T source);
        public static nint ByteOffset<T>(in T origin, in T target);
        public static ref T NullRef<T>();
        public static bool IsNullRef<T>(in T source);
        public static void SkipInit<T>(out T value);
        public static ref T Subtract<T>(ref T source, int elementOffset);
        [CLSCompliant(False)]
        public static void* Subtract<T>(void* source, int elementOffset);
        public static ref T Subtract<T>(ref T source, nint elementOffset);
        [CLSCompliant(False)]
        public static ref T Subtract<T>(ref T source, nuint elementOffset);
        public static ref T SubtractByteOffset<T>(ref T source, nint byteOffset);
        [CLSCompliant(False)]
        public static ref T SubtractByteOffset<T>(ref T source, nuint byteOffset);
        public static ref T Unbox<T>(object box) where T : struct;
    }
}

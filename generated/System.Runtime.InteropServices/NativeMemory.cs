#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    public static class NativeMemory
    {
        [CLSCompliant(False)]
        public static void* Alloc(nuint elementCount, nuint elementSize);
        [CLSCompliant(False)]
        public static void* AllocZeroed(nuint byteCount);
        [CLSCompliant(False)]
        public static void Clear(void* ptr, nuint byteCount);
        [CLSCompliant(False)]
        public static void Copy(void* source, void* destination, nuint byteCount);
        [CLSCompliant(False)]
        public static void Fill(void* ptr, nuint byteCount, byte value);
        [CLSCompliant(False)]
        public static void* AlignedAlloc(nuint byteCount, nuint alignment);
        [CLSCompliant(False)]
        public static void AlignedFree(void* ptr);
        [CLSCompliant(False)]
        public static void* AlignedRealloc(void* ptr, nuint byteCount, nuint alignment);
        [CLSCompliant(False)]
        public static void* Alloc(nuint byteCount);
        [CLSCompliant(False)]
        public static void* AllocZeroed(nuint elementCount, nuint elementSize);
        [CLSCompliant(False)]
        public static void Free(void* ptr);
        [CLSCompliant(False)]
        public static void* Realloc(void* ptr, nuint byteCount);
    }
}

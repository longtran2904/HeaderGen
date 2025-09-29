#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public static class Buffer
    {
        public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count);
        public static int ByteLength(Array array);
        public static byte GetByte(Array array, int index);
        public static void SetByte(Array array, int index, byte value);
        [CLSCompliant(False)]
        public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy);
        [CLSCompliant(False)]
        public static void MemoryCopy(void* source, void* destination, ulong destinationSizeInBytes, ulong sourceBytesToCopy);
    }
}

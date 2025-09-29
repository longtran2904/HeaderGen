#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Buffers;
using System.Collections.Generic;

namespace System.Runtime.InteropServices
{
    public static class MemoryMarshal
    {

        public static ref T GetArrayDataReference<T>(T[] array);
        public static ref byte GetArrayDataReference(Array array);
        public static Span<byte> AsBytes<T>(Span<T> span) where T : struct;
        public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) where T : struct;
        public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory);
        public static ref T GetReference<T>(Span<T> span);
        public static ref T GetReference<T>(ReadOnlySpan<T> span);
        public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) where TFrom : struct where TTo : struct;
        public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) where TFrom : struct where TTo : struct;
        public static Span<T> CreateSpan<T>(scoped ref T reference, int length);
        public static ReadOnlySpan<T> CreateReadOnlySpan<T>(scoped in T reference, int length);
        [CLSCompliant(False)]
        public static ReadOnlySpan<char> CreateReadOnlySpanFromNullTerminated(char* value);
        [CLSCompliant(False)]
        public static ReadOnlySpan<byte> CreateReadOnlySpanFromNullTerminated(byte* value);
        public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment);
        public static bool TryGetMemoryManager<T, TManager>(ReadOnlyMemory<T> memory, out TManager manager) where TManager : MemoryManager<T>;
        public static bool TryGetMemoryManager<T, TManager>(ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) where TManager : MemoryManager<T>;
        public static IEnumerable<T> ToEnumerable<T>(ReadOnlyMemory<T> memory);
        public static bool TryGetString(ReadOnlyMemory<char> memory, out string text, out int start, out int length);
        public static T Read<T>(ReadOnlySpan<byte> source) where T : struct;
        public static bool TryRead<T>(ReadOnlySpan<byte> source, out T value) where T : struct;
        public static void Write<T>(Span<byte> destination, in T value) where T : struct;
        public static bool TryWrite<T>(Span<byte> destination, in T value) where T : struct;
        public static ref T AsRef<T>(Span<byte> span) where T : struct;
        public static ref readonly T AsRef<T>(ReadOnlySpan<byte> span) where T : struct;
        public static Memory<T> CreateFromPinnedArray<T>(T[] array, int start, int length);
    }
}

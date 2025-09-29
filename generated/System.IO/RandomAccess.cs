#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
    public static class RandomAccess
    {

        public static long GetLength(SafeFileHandle handle);
        public static void SetLength(SafeFileHandle handle, long length);
        public static int Read(SafeFileHandle handle, Span<byte> buffer, long fileOffset);
        public static long Read(SafeFileHandle handle, IReadOnlyList<Memory<byte>> buffers, long fileOffset);
        public static ValueTask<int> ReadAsync(SafeFileHandle handle, Memory<byte> buffer, long fileOffset, CancellationToken cancellationToken = null);
        public static ValueTask<long> ReadAsync(SafeFileHandle handle, IReadOnlyList<Memory<byte>> buffers, long fileOffset, CancellationToken cancellationToken = null);
        public static void Write(SafeFileHandle handle, ReadOnlySpan<byte> buffer, long fileOffset);
        public static void Write(SafeFileHandle handle, IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset);
        public static ValueTask WriteAsync(SafeFileHandle handle, ReadOnlyMemory<byte> buffer, long fileOffset, CancellationToken cancellationToken = null);
        public static ValueTask WriteAsync(SafeFileHandle handle, IReadOnlyList<ReadOnlyMemory<byte>> buffers, long fileOffset, CancellationToken cancellationToken = null);
        public static void FlushToDisk(SafeFileHandle handle);
    }
}

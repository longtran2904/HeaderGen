#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Buffers;
using System.ComponentModel;

namespace System.Text.Unicode
{
    public static class Utf8
    {

        public static OperationStatus FromUtf16(ReadOnlySpan<char> source, Span<byte> destination, out int charsRead, out int bytesWritten, bool replaceInvalidSequences = True, bool isFinalBlock = True);
        public static OperationStatus ToUtf16(ReadOnlySpan<byte> source, Span<char> destination, out int bytesRead, out int charsWritten, bool replaceInvalidSequences = True, bool isFinalBlock = True);
        public static bool TryWrite(Span<byte> destination, ref TryWriteInterpolatedStringHandler handler, out int bytesWritten);
        public static bool TryWrite(Span<byte> destination, IFormatProvider provider, ref TryWriteInterpolatedStringHandler handler, out int bytesWritten);
        public static bool IsValid(ReadOnlySpan<byte> value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
        public ref struct TryWriteInterpolatedStringHandler
        {

            public TryWriteInterpolatedStringHandler(int literalLength, int formattedCount, Span<byte> destination, out bool shouldAppend);
            public TryWriteInterpolatedStringHandler(int literalLength, int formattedCount, Span<byte> destination, IFormatProvider provider, out bool shouldAppend);

            public bool AppendLiteral(string value);
            public bool AppendFormatted<T>(T value);
            public bool AppendFormatted<T>(T value, string format);
            public bool AppendFormatted<T>(T value, int alignment);
            public bool AppendFormatted<T>(T value, int alignment, string format);
            public bool AppendFormatted(scoped ReadOnlySpan<char> value);
            public bool AppendFormatted(scoped ReadOnlySpan<char> value, int alignment = 0, string format = null);
            public bool AppendFormatted(scoped ReadOnlySpan<byte> utf8Value);
            public bool AppendFormatted(scoped ReadOnlySpan<byte> utf8Value, int alignment = 0, string format = null);
            public bool AppendFormatted(string value);
            public bool AppendFormatted(string value, int alignment = 0, string format = null);
            public bool AppendFormatted(object value, int alignment = 0, string format = null);
        }
    }
}

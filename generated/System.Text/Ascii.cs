#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Buffers;

namespace System.Text
{
    public static class Ascii
    {
        public static bool IsValid(ReadOnlySpan<byte> value);
        public static bool IsValid(ReadOnlySpan<char> value);
        public static bool IsValid(byte value);
        public static bool IsValid(char value);
        public static OperationStatus ToUpper(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
        public static OperationStatus ToUpper(ReadOnlySpan<char> source, Span<char> destination, out int charsWritten);
        public static OperationStatus ToUpper(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten);
        public static OperationStatus ToUpper(ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten);
        public static OperationStatus ToLower(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten);
        public static OperationStatus ToLower(ReadOnlySpan<char> source, Span<char> destination, out int charsWritten);
        public static OperationStatus ToLower(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten);
        public static OperationStatus ToLower(ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten);
        public static OperationStatus ToLowerInPlace(Span<byte> value, out int bytesWritten);
        public static OperationStatus ToLowerInPlace(Span<char> value, out int charsWritten);
        public static OperationStatus ToUpperInPlace(Span<byte> value, out int bytesWritten);
        public static OperationStatus ToUpperInPlace(Span<char> value, out int charsWritten);
        public static bool Equals(ReadOnlySpan<byte> left, ReadOnlySpan<byte> right);
        public static bool Equals(ReadOnlySpan<byte> left, ReadOnlySpan<char> right);
        public static bool Equals(ReadOnlySpan<char> left, ReadOnlySpan<byte> right);
        public static bool Equals(ReadOnlySpan<char> left, ReadOnlySpan<char> right);
        public static bool EqualsIgnoreCase(ReadOnlySpan<byte> left, ReadOnlySpan<byte> right);
        public static bool EqualsIgnoreCase(ReadOnlySpan<byte> left, ReadOnlySpan<char> right);
        public static bool EqualsIgnoreCase(ReadOnlySpan<char> left, ReadOnlySpan<byte> right);
        public static bool EqualsIgnoreCase(ReadOnlySpan<char> left, ReadOnlySpan<char> right);
        public static OperationStatus ToUtf16(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten);
        public static OperationStatus FromUtf16(ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten);
        public static Range Trim(ReadOnlySpan<byte> value);
        public static Range Trim(ReadOnlySpan<char> value);
        public static Range TrimStart(ReadOnlySpan<byte> value);
        public static Range TrimStart(ReadOnlySpan<char> value);
        public static Range TrimEnd(ReadOnlySpan<byte> value);
        public static Range TrimEnd(ReadOnlySpan<char> value);
    }
}

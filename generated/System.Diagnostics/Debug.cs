#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;

namespace System.Diagnostics
{
    public static class Debug
    {
        public static bool AutoFlush { get; set; }
        public static int IndentLevel { get; set; }
        public static int IndentSize { get; set; }

        public static DebugProvider SetProvider(DebugProvider provider);
        [Conditional("DEBUG")]
        public static void Close();
        [Conditional("DEBUG")]
        public static void Flush();
        [Conditional("DEBUG")]
        public static void Indent();
        [Conditional("DEBUG")]
        public static void Unindent();
        [Conditional("DEBUG")]
        public static void Print(string message);
        [Conditional("DEBUG")]
        public static void Print(string format, params object[] args);
        [Conditional("DEBUG")]
        public static void Assert(bool condition);
        [Conditional("DEBUG")]
        public static void Assert(bool condition, string message);
        [Conditional("DEBUG")]
        public static void Assert(bool condition, ref AssertInterpolatedStringHandler message);
        [Conditional("DEBUG")]
        public static void Assert(bool condition, string message, string detailMessage);
        [Conditional("DEBUG")]
        public static void Assert(bool condition, ref AssertInterpolatedStringHandler message, ref AssertInterpolatedStringHandler detailMessage);
        [Conditional("DEBUG")]
        public static void Assert(bool condition, string message, string detailMessageFormat, params object[] args);
        [Conditional("DEBUG")]
        public static void Fail(string message);
        [Conditional("DEBUG")]
        public static void Fail(string message, string detailMessage);
        [Conditional("DEBUG")]
        public static void WriteLine(string message);
        [Conditional("DEBUG")]
        public static void Write(string message);
        [Conditional("DEBUG")]
        public static void WriteLine(object value);
        [Conditional("DEBUG")]
        public static void WriteLine(object value, string category);
        [Conditional("DEBUG")]
        public static void WriteLine(string format, params object[] args);
        [Conditional("DEBUG")]
        public static void WriteLine(string message, string category);
        [Conditional("DEBUG")]
        public static void Write(object value);
        [Conditional("DEBUG")]
        public static void Write(string message, string category);
        [Conditional("DEBUG")]
        public static void Write(object value, string category);
        [Conditional("DEBUG")]
        public static void WriteIf(bool condition, string message);
        [Conditional("DEBUG")]
        public static void WriteIf(bool condition, ref WriteIfInterpolatedStringHandler message);
        [Conditional("DEBUG")]
        public static void WriteIf(bool condition, object value);
        [Conditional("DEBUG")]
        public static void WriteIf(bool condition, string message, string category);
        [Conditional("DEBUG")]
        public static void WriteIf(bool condition, ref WriteIfInterpolatedStringHandler message, string category);
        [Conditional("DEBUG")]
        public static void WriteIf(bool condition, object value, string category);
        [Conditional("DEBUG")]
        public static void WriteLineIf(bool condition, object value);
        [Conditional("DEBUG")]
        public static void WriteLineIf(bool condition, object value, string category);
        [Conditional("DEBUG")]
        public static void WriteLineIf(bool condition, string message);
        [Conditional("DEBUG")]
        public static void WriteLineIf(bool condition, ref WriteIfInterpolatedStringHandler message);
        [Conditional("DEBUG")]
        public static void WriteLineIf(bool condition, string message, string category);
        [Conditional("DEBUG")]
        public static void WriteLineIf(bool condition, ref WriteIfInterpolatedStringHandler message, string category);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct AssertInterpolatedStringHandler
        {
            public AssertInterpolatedStringHandler(int literalLength, int formattedCount, bool condition, out bool shouldAppend);

            public void AppendLiteral(string value);
            public void AppendFormatted<T>(T value);
            public void AppendFormatted<T>(T value, string format);
            public void AppendFormatted<T>(T value, int alignment);
            public void AppendFormatted<T>(T value, int alignment, string format);
            public void AppendFormatted(ReadOnlySpan<char> value);
            public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string format = null);
            public void AppendFormatted(string value);
            public void AppendFormatted(string value, int alignment = 0, string format = null);
            public void AppendFormatted(object value, int alignment = 0, string format = null);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct WriteIfInterpolatedStringHandler
        {
            public WriteIfInterpolatedStringHandler(int literalLength, int formattedCount, bool condition, out bool shouldAppend);

            public void AppendLiteral(string value);
            public void AppendFormatted<T>(T value);
            public void AppendFormatted<T>(T value, string format);
            public void AppendFormatted<T>(T value, int alignment);
            public void AppendFormatted<T>(T value, int alignment, string format);
            public void AppendFormatted(ReadOnlySpan<char> value);
            public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string format = null);
            public void AppendFormatted(string value);
            public void AppendFormatted(string value, int alignment = 0, string format = null);
            public void AppendFormatted(object value, int alignment = 0, string format = null);
        }
    }
}

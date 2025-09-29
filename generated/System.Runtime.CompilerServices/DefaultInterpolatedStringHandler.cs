#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
    public ref struct DefaultInterpolatedStringHandler
    {

        public DefaultInterpolatedStringHandler(int literalLength, int formattedCount);
        public DefaultInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider provider);
        public DefaultInterpolatedStringHandler(int literalLength, int formattedCount, IFormatProvider provider, Span<char> initialBuffer);

        public override string ToString();
        public string ToStringAndClear();
        public void AppendLiteral(string value);
        public void AppendFormatted<T>(T value);
        public void AppendFormatted<T>(T value, string format);
        public void AppendFormatted<T>(T value, int alignment);
        public void AppendFormatted<T>(T value, int alignment, string format);
        public void AppendFormatted(scoped ReadOnlySpan<char> value);
        public void AppendFormatted(scoped ReadOnlySpan<char> value, int alignment = 0, string format = null);
        public void AppendFormatted(string value);
        public void AppendFormatted(string value, int alignment = 0, string format = null);
        public void AppendFormatted(object value, int alignment = 0, string format = null);
    }
}

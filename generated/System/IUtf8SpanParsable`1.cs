#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public interface IUtf8SpanParsable<TSelf> where TSelf : IUtf8SpanParsable<TSelf>
    {
        TSelf Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider);
        bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out TSelf result);
    }
}

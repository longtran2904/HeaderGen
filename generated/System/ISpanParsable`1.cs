#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public interface ISpanParsable<TSelf> : IParsable<TSelf> where TSelf : ISpanParsable<TSelf>
    {

        TSelf Parse(ReadOnlySpan<char> s, IFormatProvider provider);
        bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out TSelf result);
    }
}

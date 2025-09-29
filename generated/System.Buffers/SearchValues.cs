#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Buffers
{
    public static class SearchValues
    {

        public static SearchValues<byte> Create(ReadOnlySpan<byte> values);
        public static SearchValues<char> Create(ReadOnlySpan<char> values);
    }
}

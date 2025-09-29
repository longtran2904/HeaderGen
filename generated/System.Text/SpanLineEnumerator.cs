#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Text
{
    [Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
    public ref struct SpanLineEnumerator
    {
        public ReadOnlySpan<char> Current { get; }

        public SpanLineEnumerator GetEnumerator();
        public bool MoveNext();
    }
}

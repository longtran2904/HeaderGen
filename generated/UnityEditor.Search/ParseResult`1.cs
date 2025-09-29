#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

namespace UnityEditor.Search
{
    public readonly struct ParseResult<T> : IParseResult
    {
        public readonly T parsedValue;
        public static readonly ParseResult<T> none;

        public ParseResult(bool success, T value);

        public bool success { get; }
    }
}

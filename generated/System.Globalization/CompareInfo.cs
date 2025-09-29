#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace System.Globalization
{
    public sealed class CompareInfo : IDeserializationCallback
    {
        public string Name { get; }
        public SortVersion Version { get; }
        public int LCID { get; }

        public static CompareInfo GetCompareInfo(int culture, Assembly assembly);
        public static CompareInfo GetCompareInfo(string name, Assembly assembly);
        public static CompareInfo GetCompareInfo(int culture);
        public static CompareInfo GetCompareInfo(string name);
        public static bool IsSortable(char ch);
        public static bool IsSortable(string text);
        public static bool IsSortable(ReadOnlySpan<char> text);
        public static bool IsSortable(Rune value);
        public int Compare(string string1, string string2);
        public int Compare(string string1, string string2, CompareOptions options);
        public int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2);
        public int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options);
        public int Compare(string string1, int offset1, string string2, int offset2);
        public int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options);
        public int Compare(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options = CompareOptions.None);
        public bool IsPrefix(string source, string prefix, CompareOptions options);
        public bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options = CompareOptions.None);
        public bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options, out int matchLength);
        public bool IsPrefix(string source, string prefix);
        public bool IsSuffix(string source, string suffix, CompareOptions options);
        public bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options = CompareOptions.None);
        public bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options, out int matchLength);
        public bool IsSuffix(string source, string suffix);
        public int IndexOf(string source, char value);
        public int IndexOf(string source, string value);
        public int IndexOf(string source, char value, CompareOptions options);
        public int IndexOf(string source, string value, CompareOptions options);
        public int IndexOf(string source, char value, int startIndex);
        public int IndexOf(string source, string value, int startIndex);
        public int IndexOf(string source, char value, int startIndex, CompareOptions options);
        public int IndexOf(string source, string value, int startIndex, CompareOptions options);
        public int IndexOf(string source, char value, int startIndex, int count);
        public int IndexOf(string source, string value, int startIndex, int count);
        public int IndexOf(string source, char value, int startIndex, int count, CompareOptions options);
        public int IndexOf(string source, string value, int startIndex, int count, CompareOptions options);
        public int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options = CompareOptions.None);
        public int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options, out int matchLength);
        public int IndexOf(ReadOnlySpan<char> source, Rune value, CompareOptions options = CompareOptions.None);
        public int LastIndexOf(string source, char value);
        public int LastIndexOf(string source, string value);
        public int LastIndexOf(string source, char value, CompareOptions options);
        public int LastIndexOf(string source, string value, CompareOptions options);
        public int LastIndexOf(string source, char value, int startIndex);
        public int LastIndexOf(string source, string value, int startIndex);
        public int LastIndexOf(string source, char value, int startIndex, CompareOptions options);
        public int LastIndexOf(string source, string value, int startIndex, CompareOptions options);
        public int LastIndexOf(string source, char value, int startIndex, int count);
        public int LastIndexOf(string source, string value, int startIndex, int count);
        public int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options);
        public int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options);
        public int LastIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options = CompareOptions.None);
        public int LastIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options, out int matchLength);
        public int LastIndexOf(ReadOnlySpan<char> source, Rune value, CompareOptions options = CompareOptions.None);
        public SortKey GetSortKey(string source, CompareOptions options);
        public SortKey GetSortKey(string source);
        public int GetSortKey(ReadOnlySpan<char> source, Span<byte> destination, CompareOptions options = CompareOptions.None);
        public int GetSortKeyLength(ReadOnlySpan<char> source, CompareOptions options = CompareOptions.None);
        public override bool Equals(object value);
        public override int GetHashCode();
        public int GetHashCode(string source, CompareOptions options);
        public int GetHashCode(ReadOnlySpan<char> source, CompareOptions options);
        public override string ToString();
    }
}

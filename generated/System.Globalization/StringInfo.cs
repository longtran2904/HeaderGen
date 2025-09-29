#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public class StringInfo
    {

        public StringInfo();
        public StringInfo(string value);

        public string String { get; set; }
        public int LengthInTextElements { get; }

        public override bool Equals(object value);
        public override int GetHashCode();
        public string SubstringByTextElements(int startingTextElement);
        public string SubstringByTextElements(int startingTextElement, int lengthInTextElements);
        public static string GetNextTextElement(string str);
        public static string GetNextTextElement(string str, int index);
        public static int GetNextTextElementLength(string str);
        public static int GetNextTextElementLength(string str, int index);
        public static int GetNextTextElementLength(ReadOnlySpan<char> str);
        public static TextElementEnumerator GetTextElementEnumerator(string str);
        public static TextElementEnumerator GetTextElementEnumerator(string str, int index);
        public static int[] ParseCombiningCharacters(string str);
    }
}

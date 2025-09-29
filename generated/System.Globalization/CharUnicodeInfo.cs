#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public static class CharUnicodeInfo
    {
        public static int GetDecimalDigitValue(char ch);
        public static int GetDecimalDigitValue(string s, int index);
        public static int GetDigitValue(char ch);
        public static int GetDigitValue(string s, int index);
        public static double GetNumericValue(char ch);
        public static double GetNumericValue(string s, int index);
        public static UnicodeCategory GetUnicodeCategory(char ch);
        public static UnicodeCategory GetUnicodeCategory(int codePoint);
        public static UnicodeCategory GetUnicodeCategory(string s, int index);
    }
}

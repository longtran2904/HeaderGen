#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    public sealed class IdnMapping
    {

        public IdnMapping();

        public bool AllowUnassigned { get; set; }
        public bool UseStd3AsciiRules { get; set; }

        public string GetAscii(string unicode);
        public string GetAscii(string unicode, int index);
        public string GetAscii(string unicode, int index, int count);
        public string GetUnicode(string ascii);
        public string GetUnicode(string ascii, int index);
        public string GetUnicode(string ascii, int index, int count);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}

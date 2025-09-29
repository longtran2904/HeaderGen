#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Serialization;

namespace System.Globalization
{
    public sealed class TextInfo : ICloneable, IDeserializationCallback
    {
        public int ANSICodePage { get; }
        public int OEMCodePage { get; }
        public int MacCodePage { get; }
        public int EBCDICCodePage { get; }
        public int LCID { get; }
        public string CultureName { get; }
        public bool IsReadOnly { get; }
        public string ListSeparator { get; set; }
        public bool IsRightToLeft { get; }

        public object Clone();
        public static TextInfo ReadOnly(TextInfo textInfo);
        public char ToLower(char c);
        public string ToLower(string str);
        public char ToUpper(char c);
        public string ToUpper(string str);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
        public string ToTitleCase(string str);
    }
}

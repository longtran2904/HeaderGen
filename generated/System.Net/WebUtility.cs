#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.IO;

namespace System.Net
{
    public static class WebUtility
    {
        public static string HtmlEncode(string value);
        public static void HtmlEncode(string value, TextWriter output);
        public static string HtmlDecode(string value);
        public static void HtmlDecode(string value, TextWriter output);
        public static string UrlEncode(string value);
        public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count);
        public static string UrlDecode(string encodedValue);
        public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count);
    }
}

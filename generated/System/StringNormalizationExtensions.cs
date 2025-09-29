#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Text;

namespace System
{
    public static class StringNormalizationExtensions
    {
        public static bool IsNormalized(this string strInput);
        public static bool IsNormalized(this string strInput, NormalizationForm normalizationForm);
        public static string Normalize(this string strInput);
        public static string Normalize(this string strInput, NormalizationForm normalizationForm);
    }
}

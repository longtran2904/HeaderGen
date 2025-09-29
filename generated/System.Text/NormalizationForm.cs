#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Text
{
    public enum NormalizationForm
    {

        FormC = 1,
        FormD = 2,
        [UnsupportedOSPlatform("browser")]
        FormKC = 5,
        [UnsupportedOSPlatform("browser")]
        FormKD = 6
    }
}

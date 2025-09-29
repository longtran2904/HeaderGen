#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Globalization
{
    [Flags]
    public enum CultureTypes
    {

        NeutralCultures = 1,
        SpecificCultures = 2,
        InstalledWin32Cultures = 4,
        AllCultures = 7,
        UserCustomCulture = 8,
        ReplacementCultures = 16,
        [Obsolete("CultureTypes.WindowsOnlyCultures has been deprecated. Use other values in CultureTypes instead.")]
        WindowsOnlyCultures = 32,
        [Obsolete("CultureTypes.FrameworkCultures has been deprecated. Use other values in CultureTypes instead.")]
        FrameworkCultures = 64
    }
}

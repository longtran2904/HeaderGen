#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public enum LoaderOptimization
    {

        [Obsolete("LoaderOptimization.DisallowBindings has been deprecated and is not supported.")]
        DisallowBindings = 4,
        [Obsolete("LoaderOptimization.DomainMask has been deprecated and is not supported.")]
        DomainMask = 3,
        MultiDomain = 2,
        MultiDomainHost = 3,
        NotSpecified = 0,
        SingleDomain = 1
    }
}

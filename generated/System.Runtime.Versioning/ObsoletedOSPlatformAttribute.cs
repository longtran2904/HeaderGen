#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Versioning
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = True, Inherited = False)]
    public sealed class ObsoletedOSPlatformAttribute : OSPlatformAttribute
    {
        public ObsoletedOSPlatformAttribute(string platformName);
        public ObsoletedOSPlatformAttribute(string platformName, string message);

        public string Message { get; }
        public string Url { get; set; }
    }
}

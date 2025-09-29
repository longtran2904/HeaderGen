#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.Versioning
{
    public static class VersioningHelper
    {
        public static string MakeVersionSafeName(string name, ResourceScope from, ResourceScope to);
        public static string MakeVersionSafeName(string name, ResourceScope from, ResourceScope to, Type type);
    }
}

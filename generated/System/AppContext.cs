#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    public static class AppContext
    {

        public static string BaseDirectory { get; }
        public static string TargetFrameworkName { get; }

        public static object GetData(string name);
        public static void SetData(string name, object data);
        public static bool TryGetSwitch(string switchName, out bool isEnabled);
        public static void SetSwitch(string switchName, bool isEnabled);
    }
}

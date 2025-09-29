#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics
{
    public static class Debugger
    {
        public static readonly string DefaultCategory;

        public static bool IsAttached { get; }

        public static void Break();
        public static bool Launch();
        public static void NotifyOfCrossThreadDependency();
        public static void Log(int level, string category, string message);
        public static bool IsLogging();
    }
}

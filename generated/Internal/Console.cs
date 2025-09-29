#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace Internal
{
    public static class Console
    {
        public static void WriteLine(string s);
        public static void WriteLine();
        public static void Write(string s);

        public static class Error
        {
            public static void Write(string s);
        }
    }
}

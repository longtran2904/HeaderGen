#region System.Console, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Console.dll
#endregion

namespace System
{
    public sealed class ConsoleCancelEventArgs : EventArgs
    {
        public bool Cancel { get; set; }
        public ConsoleSpecialKey SpecialKey { get; }
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public sealed class Mutex : WaitHandle
    {
        public Mutex(bool initiallyOwned, string name, out bool createdNew);
        public Mutex(bool initiallyOwned, string name);
        public Mutex(bool initiallyOwned);
        public Mutex();

        public static Mutex OpenExisting(string name);
        public static bool TryOpenExisting(string name, out Mutex result);
        public void ReleaseMutex();
    }
}

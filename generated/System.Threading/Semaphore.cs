#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Threading
{
    public sealed class Semaphore : WaitHandle
    {
        public Semaphore(int initialCount, int maximumCount);
        public Semaphore(int initialCount, int maximumCount, string name);
        public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew);

        [SupportedOSPlatform("windows")]
        public static Semaphore OpenExisting(string name);
        [SupportedOSPlatform("windows")]
        public static bool TryOpenExisting(string name, out Semaphore result);
        public int Release();
        public int Release(int releaseCount);
    }
}

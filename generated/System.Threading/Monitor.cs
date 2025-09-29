#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Threading
{
    public static class Monitor
    {

        public static long LockContentionCount { get; }

        public static void Enter(object obj);
        public static void Enter(object obj, ref bool lockTaken);
        public static void Exit(object obj);
        public static bool TryEnter(object obj);
        public static void TryEnter(object obj, ref bool lockTaken);
        public static bool TryEnter(object obj, int millisecondsTimeout);
        public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken);
        public static bool IsEntered(object obj);
        [UnsupportedOSPlatform("browser")]
        public static bool Wait(object obj, int millisecondsTimeout);
        public static void Pulse(object obj);
        public static void PulseAll(object obj);
        public static bool TryEnter(object obj, TimeSpan timeout);
        public static void TryEnter(object obj, TimeSpan timeout, ref bool lockTaken);
        [UnsupportedOSPlatform("browser")]
        public static bool Wait(object obj, TimeSpan timeout);
        [UnsupportedOSPlatform("browser")]
        public static bool Wait(object obj);
        [UnsupportedOSPlatform("browser")]
        public static bool Wait(object obj, int millisecondsTimeout, bool exitContext);
        [UnsupportedOSPlatform("browser")]
        public static bool Wait(object obj, TimeSpan timeout, bool exitContext);
    }
}

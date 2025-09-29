#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public struct SpinWait
    {
        public int Count { get; }
        public bool NextSpinWillYield { get; }

        public void SpinOnce();
        public void SpinOnce(int sleep1Threshold);
        public void Reset();
        public static void SpinUntil(Func<bool> condition);
        public static bool SpinUntil(Func<bool> condition, TimeSpan timeout);
        public static bool SpinUntil(Func<bool> condition, int millisecondsTimeout);
    }
}

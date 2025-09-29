#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics
{
    public class Stopwatch
    {
        public static readonly long Frequency;
        public static readonly bool IsHighResolution;

        public Stopwatch();

        public bool IsRunning { get; }
        public TimeSpan Elapsed { get; }
        public long ElapsedMilliseconds { get; }
        public long ElapsedTicks { get; }

        public void Start();
        public static Stopwatch StartNew();
        public void Stop();
        public void Reset();
        public void Restart();
        public override string ToString();
        public static long GetTimestamp();
        public static TimeSpan GetElapsedTime(long startingTimestamp);
        public static TimeSpan GetElapsedTime(long startingTimestamp, long endingTimestamp);
    }
}

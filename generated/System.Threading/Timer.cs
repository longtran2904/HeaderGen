#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading.Tasks;

namespace System.Threading
{
    public sealed class Timer : MarshalByRefObject, IAsyncDisposable, IDisposable, ITimer
    {
        public Timer(TimerCallback callback, object state, int dueTime, int period);
        public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period);
        [CLSCompliant(False)]
        public Timer(TimerCallback callback, object state, uint dueTime, uint period);
        public Timer(TimerCallback callback, object state, long dueTime, long period);
        public Timer(TimerCallback callback);

        public static long ActiveCount { get; }

        public bool Change(int dueTime, int period);
        public bool Change(TimeSpan dueTime, TimeSpan period);
        [CLSCompliant(False)]
        public bool Change(uint dueTime, uint period);
        public bool Change(long dueTime, long period);
        public bool Dispose(WaitHandle notifyObject);
        public void Dispose();
        public ValueTask DisposeAsync();
    }
}

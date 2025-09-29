#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;

namespace System
{
    public abstract class TimeProvider
    {

        protected TimeProvider();

        public static TimeProvider System { get; }
        public virtual TimeZoneInfo LocalTimeZone { get; }
        public virtual long TimestampFrequency { get; }

        public virtual DateTimeOffset GetUtcNow();
        public DateTimeOffset GetLocalNow();
        public virtual long GetTimestamp();
        public TimeSpan GetElapsedTime(long startingTimestamp, long endingTimestamp);
        public TimeSpan GetElapsedTime(long startingTimestamp);
        public virtual ITimer CreateTimer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period);
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading.Tasks;

namespace System.Threading
{
    public sealed class PeriodicTimer : IDisposable
    {
        public PeriodicTimer(TimeSpan period);
        public PeriodicTimer(TimeSpan period, TimeProvider timeProvider);

        ~PeriodicTimer();

        public TimeSpan Period { get; set; }

        public ValueTask<bool> WaitForNextTickAsync(CancellationToken cancellationToken = null);
        public void Dispose();
    }
}

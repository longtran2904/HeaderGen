#region System.Threading, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Threading.dll
#endregion

using System.Runtime.Versioning;

namespace System.Threading
{
    public class Barrier : IDisposable
    {
        public Barrier(int participantCount);
        public Barrier(int participantCount, Action<Barrier> postPhaseAction);

        public int ParticipantsRemaining { get; }
        public int ParticipantCount { get; }
        public long CurrentPhaseNumber { get; }

        [UnsupportedOSPlatform("browser")]
        public long AddParticipant();
        [UnsupportedOSPlatform("browser")]
        public long AddParticipants(int participantCount);
        public void RemoveParticipant();
        public void RemoveParticipants(int participantCount);
        [UnsupportedOSPlatform("browser")]
        public void SignalAndWait();
        [UnsupportedOSPlatform("browser")]
        public void SignalAndWait(CancellationToken cancellationToken);
        [UnsupportedOSPlatform("browser")]
        public bool SignalAndWait(TimeSpan timeout);
        [UnsupportedOSPlatform("browser")]
        public bool SignalAndWait(TimeSpan timeout, CancellationToken cancellationToken);
        [UnsupportedOSPlatform("browser")]
        public bool SignalAndWait(int millisecondsTimeout);
        [UnsupportedOSPlatform("browser")]
        public bool SignalAndWait(int millisecondsTimeout, CancellationToken cancellationToken);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public readonly struct CancellationToken : IEquatable<CancellationToken>
    {
        public CancellationToken(bool canceled);

        public static CancellationToken None { get; }
        public bool IsCancellationRequested { get; }
        public bool CanBeCanceled { get; }
        public WaitHandle WaitHandle { get; }

        public CancellationTokenRegistration Register(Action callback);
        public CancellationTokenRegistration Register(Action callback, bool useSynchronizationContext);
        public CancellationTokenRegistration Register(Action<object> callback, object state);
        public CancellationTokenRegistration Register(Action<object, CancellationToken> callback, object state);
        public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext);
        public CancellationTokenRegistration UnsafeRegister(Action<object> callback, object state);
        public CancellationTokenRegistration UnsafeRegister(Action<object, CancellationToken> callback, object state);
        public bool Equals(CancellationToken other);
        public override bool Equals(object other);
        public override int GetHashCode();
        public void ThrowIfCancellationRequested();

        public static bool operator ==(CancellationToken left, CancellationToken right);
        public static bool operator !=(CancellationToken left, CancellationToken right);
    }
}

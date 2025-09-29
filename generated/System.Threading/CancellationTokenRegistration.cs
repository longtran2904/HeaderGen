#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading.Tasks;

namespace System.Threading
{
    public readonly struct CancellationTokenRegistration : IAsyncDisposable, IDisposable, IEquatable<CancellationTokenRegistration>
    {
        public CancellationToken Token { get; }

        public void Dispose();
        public ValueTask DisposeAsync();
        public bool Unregister();
        public override bool Equals(object obj);
        public bool Equals(CancellationTokenRegistration other);
        public override int GetHashCode();

        public static bool operator ==(CancellationTokenRegistration left, CancellationTokenRegistration right);
        public static bool operator !=(CancellationTokenRegistration left, CancellationTokenRegistration right);
    }
}

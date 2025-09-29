#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Threading
{
    public struct AsyncFlowControl : IDisposable, IEquatable<AsyncFlowControl>
    {

        public void Undo();
        public void Dispose();
        public override bool Equals(object obj);
        public bool Equals(AsyncFlowControl obj);
        public override int GetHashCode();

        public static bool operator ==(AsyncFlowControl a, AsyncFlowControl b);
        public static bool operator !=(AsyncFlowControl a, AsyncFlowControl b);
    }
}

#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Buffers
{
    public abstract class MemoryManager<T> : IDisposable, IMemoryOwner<T>, IPinnable
    {
        protected MemoryManager();

        public virtual Memory<T> Memory { get; }

        public abstract Span<T> GetSpan();
        public abstract MemoryHandle Pin(int elementIndex = 0);
        public abstract void Unpin();
        protected Memory<T> CreateMemory(int length);
        protected Memory<T> CreateMemory(int start, int length);
        protected internal virtual bool TryGetArray(out ArraySegment<T> segment);
        protected abstract void Dispose(bool disposing);
    }
}

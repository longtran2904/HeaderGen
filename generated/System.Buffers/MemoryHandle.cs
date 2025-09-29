#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;

namespace System.Buffers
{
    public struct MemoryHandle : IDisposable
    {

        [CLSCompliant(False)]
        public MemoryHandle(void* pointer, GCHandle handle = null, IPinnable pinnable = null);

        [CLSCompliant(False)]
        public void* Pointer { get; }

        public void Dispose();
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Burst;

namespace Unity.Collections.LowLevel.Unsafe
{
    public sealed class DisposeSentinel
    {
        ~DisposeSentinel();

        public static void Dispose(ref AtomicSafetyHandle safety, ref DisposeSentinel sentinel);
        public static void Create(out AtomicSafetyHandle safety, out DisposeSentinel sentinel, int callSiteStackDepth, Allocator allocator);
        [BurstDiscard]
        public static void Clear(ref DisposeSentinel sentinel);
    }
}

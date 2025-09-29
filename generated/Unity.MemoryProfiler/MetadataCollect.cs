#region Unity.MemoryProfiler, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.dll
#endregion

using System;
using UnityEngine.Profiling.Memory.Experimental;

namespace Unity.MemoryProfiler
{
    public abstract class MetadataCollect : IDisposable
    {
        public MetadataCollect();

        public abstract void CollectMetadata(MetaData data);
        public void Dispose();
    }
}

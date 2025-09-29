#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering
{
    [Obsolete("Please use ProfilingScope")]
    public struct ProfilingSample : IDisposable
    {

        public ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null);
        public ProfilingSample(CommandBuffer cmd, string format, object arg);
        public ProfilingSample(CommandBuffer cmd, string format, params object[] args);

        public void Dispose();
    }
}

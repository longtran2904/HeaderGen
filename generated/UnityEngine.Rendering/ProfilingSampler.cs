#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class ProfilingSampler
    {
        public ProfilingSampler(string name);

        public string name { get; }
        public bool enableRecording { set; }
        public float gpuElapsedTime { get; }
        public int gpuSampleCount { get; }
        public float cpuElapsedTime { get; }
        public int cpuSampleCount { get; }
        public float inlineCpuElapsedTime { get; }
        public int inlineCpuSampleCount { get; }

        public static ProfilingSampler Get<TEnum>(TEnum marker) where TEnum : Enum;
        public void Begin(CommandBuffer cmd);
        public void End(CommandBuffer cmd);
    }
}

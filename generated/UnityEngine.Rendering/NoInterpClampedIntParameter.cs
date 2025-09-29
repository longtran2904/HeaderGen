#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class NoInterpClampedIntParameter : VolumeParameter<int>
    {
        [NonSerialized]
        public int min;
        [NonSerialized]
        public int max;

        public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = False);

        public override int value { get; set; }
    }
}

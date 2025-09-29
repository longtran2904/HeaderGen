#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class ClampedFloatParameter : FloatParameter
    {
        [NonSerialized]
        public float min;
        [NonSerialized]
        public float max;

        public ClampedFloatParameter(float value, float min, float max, bool overrideState = False);

        public override float value { get; set; }
    }
}

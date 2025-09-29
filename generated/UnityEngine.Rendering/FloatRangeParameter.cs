#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class FloatRangeParameter : VolumeParameter<Vector2>
    {

        [NonSerialized]
        public float min;
        [NonSerialized]
        public float max;

        public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = False);

        public override Vector2 value { get; set; }

        public override void Interp(Vector2 from, Vector2 to, float t);
    }
}

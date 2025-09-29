#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class ColorParameter : VolumeParameter<Color>
    {

        [NonSerialized]
        public bool hdr;
        [NonSerialized]
        public bool showAlpha;
        [NonSerialized]
        public bool showEyeDropper;

        public ColorParameter(Color value, bool overrideState = False);
        public ColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = False);

        public override void Interp(Color from, Color to, float t);
    }
}

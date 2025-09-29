#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class FloatParameter : VolumeParameter<float>
    {
        public FloatParameter(float value, bool overrideState = False);

        public sealed override void Interp(float from, float to, float t);
    }
}

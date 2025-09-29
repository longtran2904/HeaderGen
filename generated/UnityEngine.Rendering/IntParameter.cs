#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class IntParameter : VolumeParameter<int>
    {

        public IntParameter(int value, bool overrideState = False);

        public sealed override void Interp(int from, int to, float t);
    }
}

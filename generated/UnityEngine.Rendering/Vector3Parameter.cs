#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public class Vector3Parameter : VolumeParameter<Vector3>
    {

        public Vector3Parameter(Vector3 value, bool overrideState = False);

        public override void Interp(Vector3 from, Vector3 to, float t);
    }
}

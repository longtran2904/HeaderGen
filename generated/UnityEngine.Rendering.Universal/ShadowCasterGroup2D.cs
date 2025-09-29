#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
    [MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
    public abstract class ShadowCasterGroup2D : MonoBehaviour
    {

        protected ShadowCasterGroup2D();

        public List<ShadowCaster2D> GetShadowCasters();
        public int GetShadowGroup();
        public void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D);
        public void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D);
    }
}

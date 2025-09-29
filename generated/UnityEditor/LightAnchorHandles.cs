#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class LightAnchorHandles
    {

        public LightAnchorHandles(LightAnchor target);

        public Vector3 lightPosition { get; set; }
        public Vector3 anchorPosition { get; set; }

        public void OnGUI();
    }
}

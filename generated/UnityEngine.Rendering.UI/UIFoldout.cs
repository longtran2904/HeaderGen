#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    [ExecuteAlways]
    public class UIFoldout : Toggle
    {

        public GameObject content;
        public GameObject arrowOpened;
        public GameObject arrowClosed;

        public UIFoldout();

        protected override void Start();
        public void SetState(bool state);
        public void SetState(bool state, bool rebuildLayout);
    }
}

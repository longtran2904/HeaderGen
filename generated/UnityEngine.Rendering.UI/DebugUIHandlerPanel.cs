#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    public class DebugUIHandlerPanel : MonoBehaviour
    {
        public Text nameLabel;
        public ScrollRect scrollRect;
        public RectTransform viewport;
        public DebugUIHandlerCanvas Canvas;
        protected internal DebugUI.Panel m_Panel;

        public DebugUIHandlerPanel();

        public void SelectNextItem();
        public void SelectPreviousItem();
        public void OnScrollbarClicked();
        public void ResetDebugManager();
    }
}

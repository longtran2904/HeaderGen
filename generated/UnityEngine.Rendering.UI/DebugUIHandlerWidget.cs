#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering.UI
{
    public class DebugUIHandlerWidget : MonoBehaviour
    {

        [HideInInspector]
        public Color colorDefault;
        [HideInInspector]
        public Color colorSelected;
        protected DebugUI.Widget m_Widget;

        public DebugUIHandlerWidget();

        public DebugUIHandlerWidget parentUIHandler { get; set; }
        public DebugUIHandlerWidget previousUIHandler { get; set; }
        public DebugUIHandlerWidget nextUIHandler { get; set; }

        protected virtual void OnEnable();
        protected T CastWidget<T>() where T : DebugUI.Widget;
        public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous);
        public virtual void OnDeselection();
        public virtual void OnAction();
        public virtual void OnIncrement(bool fast);
        public virtual void OnDecrement(bool fast);
        public virtual DebugUIHandlerWidget Previous();
        public virtual DebugUIHandlerWidget Next();
    }
}

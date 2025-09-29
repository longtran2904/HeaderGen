#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine;
using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    public class DebugUIDrawer
    {
        public DebugUIDrawer();

        protected T Cast<T>(object o) where T : class;
        public virtual void Begin(DebugUI.Widget widget, DebugState state);
        public virtual bool OnGUI(DebugUI.Widget widget, DebugState state);
        public virtual void End(DebugUI.Widget widget, DebugState state);
        protected void Apply(DebugUI.IValueField widget, DebugState state, object value);
        protected Rect PrepareControlRect(float height = -1, bool fullWidth = False);
    }
}

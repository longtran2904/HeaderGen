#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    [DebugUIDrawer(typeof(DebugUI.Vector2Field))]
    public sealed class DebugUIDrawerVector2Field : DebugUIDrawer
    {

        public DebugUIDrawerVector2Field();

        public override bool OnGUI(DebugUI.Widget widget, DebugState state);
    }
}

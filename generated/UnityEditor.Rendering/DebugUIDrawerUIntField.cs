#region Unity.RenderPipelines.Core.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Editor.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEditor.Rendering
{
    [DebugUIDrawer(typeof(DebugUI.UIntField))]
    public sealed class DebugUIDrawerUIntField : DebugUIDrawer
    {

        public DebugUIDrawerUIntField();

        public override bool OnGUI(DebugUI.Widget widget, DebugState state);
    }
}

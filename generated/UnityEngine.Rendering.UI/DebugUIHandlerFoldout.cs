#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    public class DebugUIHandlerFoldout : DebugUIHandlerWidget
    {

        public Text nameLabel;
        public UIFoldout valueToggle;

        public DebugUIHandlerFoldout();

        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous);
        public override void OnDeselection();
        public override void OnIncrement(bool fast);
        public override void OnDecrement(bool fast);
        public override void OnAction();
        public override DebugUIHandlerWidget Next();
    }
}

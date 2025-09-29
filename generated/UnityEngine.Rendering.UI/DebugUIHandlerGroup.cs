#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    public class DebugUIHandlerGroup : DebugUIHandlerWidget
    {
        public Text nameLabel;
        public Transform header;

        public DebugUIHandlerGroup();

        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous);
        public override DebugUIHandlerWidget Next();
    }
}

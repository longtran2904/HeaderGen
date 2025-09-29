#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
    {
        public Text nameLabel;
        public Toggle valueToggle;
        public Image checkmarkImage;
        public Func<int, bool> getter;
        public Action<int, bool> setter;

        public DebugUIHandlerIndirectToggle();

        public void Init();
        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous);
        public override void OnDeselection();
        public override void OnAction();
    }
}

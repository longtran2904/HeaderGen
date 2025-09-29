#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
    [AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
    public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
    {

        public PanelRaycaster();

        public IPanel panel { get; set; }
        public override int sortOrderPriority { get; }
        public override int renderOrderPriority { get; }
        public override Camera eventCamera { get; }

        public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
    }
}

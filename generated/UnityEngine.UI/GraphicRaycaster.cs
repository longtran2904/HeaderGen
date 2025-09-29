#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("Event/Graphic Raycaster")]
    [RequireComponent(typeof(Canvas))]
    public class GraphicRaycaster : BaseRaycaster
    {

        [SerializeField]
        protected LayerMask m_BlockingMask;
        protected const int kNoEventMaskSet = -1;

        protected GraphicRaycaster();

        public override int sortOrderPriority { get; }
        public override int renderOrderPriority { get; }
        public bool ignoreReversedGraphics { get; set; }
        public BlockingObjects blockingObjects { get; set; }
        public LayerMask blockingMask { get; set; }
        public override Camera eventCamera { get; }

        public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
        public enum BlockingObjects
        {

            None = 0,
            TwoD = 1,
            ThreeD = 2,
            All = 3
        }
    }
}

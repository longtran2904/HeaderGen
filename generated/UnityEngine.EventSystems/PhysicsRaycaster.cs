#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    [AddComponentMenu("Event/Physics Raycaster")]
    [RequireComponent(typeof(Camera))]
    public class PhysicsRaycaster : BaseRaycaster
    {
        protected Camera m_EventCamera;
        [SerializeField]
        protected LayerMask m_EventMask;
        [SerializeField]
        protected int m_MaxRayIntersections;
        protected int m_LastMaxRayIntersections;
        protected const int kNoEventMaskSet = -1;

        protected PhysicsRaycaster();

        public override Camera eventCamera { get; }
        public virtual int depth { get; }
        public int finalEventMask { get; }
        public LayerMask eventMask { get; set; }
        public int maxRayIntersections { get; set; }

        protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
        public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
    }
}

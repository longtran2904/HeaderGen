#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    [RequireComponent(typeof(EventSystem))]
    public abstract class BaseInputModule : UIBehaviour
    {

        [NonSerialized]
        protected List<RaycastResult> m_RaycastResultCache;
        protected BaseInput m_InputOverride;

        protected BaseInputModule();

        public BaseInput input { get; }
        public BaseInput inputOverride { get; set; }
        protected EventSystem eventSystem { get; }

        protected override void OnEnable();
        protected override void OnDisable();
        public abstract void Process();
        protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates);
        protected static MoveDirection DetermineMoveDirection(float x, float y);
        protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
        protected static GameObject FindCommonRoot(GameObject g1, GameObject g2);
        protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget);
        protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
        protected virtual BaseEventData GetBaseEventData();
        public virtual bool IsPointerOverGameObject(int pointerId);
        public virtual bool ShouldActivateModule();
        public virtual void DeactivateModule();
        public virtual void ActivateModule();
        public virtual void UpdateModule();
        public virtual bool IsModuleSupported();
        public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData);
    }
}

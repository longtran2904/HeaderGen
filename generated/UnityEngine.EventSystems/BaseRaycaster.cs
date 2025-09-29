#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    public abstract class BaseRaycaster : UIBehaviour
    {
        protected BaseRaycaster();

        public abstract Camera eventCamera { get; }
        [Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
        public virtual int priority { get; }
        public virtual int sortOrderPriority { get; }
        public virtual int renderOrderPriority { get; }
        public BaseRaycaster rootRaycaster { get; }

        public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
        public override string ToString();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnCanvasHierarchyChanged();
        protected override void OnTransformParentChanged();
    }
}

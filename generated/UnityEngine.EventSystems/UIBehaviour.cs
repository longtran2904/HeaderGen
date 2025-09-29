#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

namespace UnityEngine.EventSystems
{
    public abstract class UIBehaviour : MonoBehaviour
    {

        protected UIBehaviour();

        protected virtual void Awake();
        protected virtual void OnEnable();
        protected virtual void Start();
        protected virtual void OnDisable();
        protected virtual void OnDestroy();
        public virtual bool IsActive();
        protected virtual void OnValidate();
        protected virtual void Reset();
        protected virtual void OnRectTransformDimensionsChange();
        protected virtual void OnBeforeTransformParentChanged();
        protected virtual void OnTransformParentChanged();
        protected virtual void OnDidApplyAnimationProperties();
        protected virtual void OnCanvasGroupChanged();
        protected virtual void OnCanvasHierarchyChanged();
        public bool IsDestroyed();
    }
}

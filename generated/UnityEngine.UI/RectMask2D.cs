#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Rect Mask 2D", 14)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(RectTransform))]
    public class RectMask2D : UIBehaviour, ICanvasRaycastFilter, IClipper
    {

        protected RectMask2D();

        public Vector4 padding { get; set; }
        public Vector2Int softness { get; set; }
        public Rect canvasRect { get; }
        public RectTransform rectTransform { get; }

        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDestroy();
        protected override void OnValidate();
        public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
        public virtual void PerformClipping();
        public virtual void UpdateClipSoftness();
        public void AddClippable(IClippable clippable);
        public void RemoveClippable(IClippable clippable);
        protected override void OnTransformParentChanged();
        protected override void OnCanvasHierarchyChanged();
    }
}

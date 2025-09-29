#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public abstract class GraphElement : VisualElement, ISelectable
    {

        protected GraphElement();

        public Color elementTypeColor { get; set; }
        public int layer { get; set; }
        public virtual string title { get; set; }
        public virtual bool showInMiniMap { get; set; }
        public Capabilities capabilities { get; set; }
        public bool selected { get; set; }

        public void ResetLayer();
        protected virtual void OnCustomStyleResolved(ICustomStyle style);
        public virtual bool IsSelectable();
        public virtual bool IsMovable();
        public virtual bool IsResizable();
        public virtual bool IsDroppable();
        public virtual bool IsAscendable();
        public virtual bool IsRenamable();
        public virtual bool IsCopiable();
        public virtual bool IsSnappable();
        public virtual bool IsGroupable();
        public virtual bool IsStackable();
        public virtual Vector3 GetGlobalCenter();
        public virtual void UpdatePresenterPosition();
        public virtual Rect GetPosition();
        public virtual void SetPosition(Rect newPos);
        public virtual void OnSelected();
        public virtual void OnUnselected();
        public virtual bool HitTest(Vector2 localPoint);
        public virtual void Select(VisualElement selectionContainer, bool additive);
        public virtual void Unselect(VisualElement selectionContainer);
        public virtual bool IsSelected(VisualElement selectionContainer);
    }
}

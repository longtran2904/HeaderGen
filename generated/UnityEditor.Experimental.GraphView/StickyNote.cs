#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class StickyNote : GraphElement, IResizable
    {
        public static readonly Vector2 defaultSize;

        public StickyNote();
        public StickyNote(Vector2 position);
        public StickyNote(string uiFile, Vector2 position);

        public StickyNoteTheme theme { get; set; }
        public StickyNoteFontSize fontSize { get; set; }
        public string contents { get; set; }
        public override string title { get; set; }

        public void FitText(bool onlyIfSmaller);
        public void BuildContextualMenu(ContextualMenuPopulateEvent evt);
        public override void SetPosition(Rect rect);
        public override Rect GetPosition();
        public override void UpdatePresenterPosition();
        public virtual void OnStartResize();
        public virtual void OnResized();

        public class UxmlFactory : UxmlFactory<StickyNote>
        {
            public UxmlFactory();
        }
    }
}

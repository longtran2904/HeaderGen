#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class StickyNoteChangeEvent : EventBase<StickyNoteChangeEvent>
    {
        public StickyNoteChangeEvent();

        public StickyNoteChange change { get; protected set; }

        public static StickyNoteChangeEvent GetPooled(StickyNote target, StickyNoteChange change);
    }
}

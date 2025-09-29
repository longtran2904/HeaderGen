#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class MultiColumnHeaderState
    {
        public MultiColumnHeaderState(Column[] columns);

        public int sortedColumnIndex { get; set; }
        public int maximumNumberOfSortedColumns { get; set; }
        public int[] sortedColumns { get; set; }
        public Column[] columns { get; }
        public int[] visibleColumns { get; set; }
        public float widthOfAllVisibleColumns { get; }

        public static bool CanOverwriteSerializedFields(MultiColumnHeaderState source, MultiColumnHeaderState destination);
        public static void OverwriteSerializedFields(MultiColumnHeaderState source, MultiColumnHeaderState destination);

        public class Column
        {
            [SerializeField]
            public float width;
            [SerializeField]
            public bool sortedAscending;
            [SerializeField]
            public GUIContent headerContent;
            [SerializeField]
            public string contextMenuText;
            [SerializeField]
            public TextAlignment headerTextAlignment;
            [SerializeField]
            public TextAlignment sortingArrowAlignment;
            [SerializeField]
            public float minWidth;
            [SerializeField]
            public float maxWidth;
            [SerializeField]
            public bool autoResize;
            [SerializeField]
            public bool allowToggleVisibility;
            [SerializeField]
            public bool canSort;
            [SerializeField]
            public int userData;

            public Column();
        }
    }
}

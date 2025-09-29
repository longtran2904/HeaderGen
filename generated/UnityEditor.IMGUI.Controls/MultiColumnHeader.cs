#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class MultiColumnHeader
    {

        public MultiColumnHeader(MultiColumnHeaderState state);

        public float height { get; set; }
        public bool canSort { get; set; }
        protected int currentColumnIndex { get; }
        protected bool allowDraggingColumnsToReorder { get; set; }
        public int sortedColumnIndex { get; set; }
        public MultiColumnHeaderState state { get; set; }

        public event HeaderCallback sortingChanged;
        public event HeaderCallback visibleColumnsChanged;
        public event Action<int> columnSettingsChanged;
        public event Action<int, int> columnsSwapped;

        public void SetSortingColumns(int[] columnIndices, bool[] sortAscending);
        public void SetSorting(int columnIndex, bool sortAscending);
        public void SetSortDirection(int columnIndex, bool sortAscending);
        public bool IsSortedAscending(int columnIndex);
        public MultiColumnHeaderState.Column GetColumn(int columnIndex);
        public bool IsColumnVisible(int columnIndex);
        public int GetVisibleColumnIndex(int columnIndex);
        public Rect GetCellRect(int visibleColumnIndex, Rect rowRect);
        public Rect GetColumnRect(int visibleColumnIndex);
        public void ResizeToFit();
        public virtual void OnGUI(Rect rect, float xScroll);
        protected virtual void ColumnHeaderClicked(MultiColumnHeaderState.Column column, int columnIndex);
        protected virtual void OnSortingChanged();
        protected virtual void ColumnHeaderGUI(MultiColumnHeaderState.Column column, Rect headerRect, int columnIndex);
        protected void SortingButton(MultiColumnHeaderState.Column column, Rect headerRect, int columnIndex);
        protected virtual void AddColumnHeaderContextMenuItems(GenericMenu menu);
        protected virtual void OnVisibleColumnsChanged();
        protected virtual void ToggleVisibility(int columnIndex);
        public void Repaint();
        public delegate void HeaderCallback(MultiColumnHeader multiColumnHeader);
        public static class DefaultGUI
        {

            public static float defaultHeight { get; }
            public static float minimumHeight { get; }
            public static float columnContentMargin { get; }
        }
        public static class DefaultStyles
        {

            public static GUIStyle columnHeader;
            public static GUIStyle columnHeaderRightAligned;
            public static GUIStyle columnHeaderCenterAligned;
            public static GUIStyle background;
        }
    }
}

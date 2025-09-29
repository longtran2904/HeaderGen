#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public abstract class TreeView
    {
        public TreeView(TreeViewState state);
        public TreeView(TreeViewState state, MultiColumnHeader multiColumnHeader);

        protected GetNewSelectionFunction getNewSelectionOverride { set; }
        protected DoFoldoutCallback foldoutOverride { get; set; }
        public TreeViewState state { get; }
        public MultiColumnHeader multiColumnHeader { get; set; }
        protected TreeViewItem rootItem { get; }
        protected bool isInitialized { get; }
        protected Rect treeViewRect { get; set; }
        protected float baseIndent { get; set; }
        protected float foldoutWidth { get; }
        protected float extraSpaceBeforeIconAndLabel { get; set; }
        protected float customFoldoutYOffset { get; set; }
        protected int columnIndexForTreeFoldouts { get; set; }
        protected bool useScrollView { get; set; }
        protected float depthIndentWidth { get; set; }
        protected bool showAlternatingRowBackgrounds { get; set; }
        protected bool showBorder { get; set; }
        protected bool showingHorizontalScrollBar { get; }
        protected bool showingVerticalScrollBar { get; }
        protected float cellMargin { get; set; }
        public float totalHeight { get; }
        protected float rowHeight { get; set; }
        public int treeViewControlID { get; set; }
        protected bool isDragging { get; }
        public bool hasSearch { get; }
        public string searchString { get; set; }

        protected abstract TreeViewItem BuildRoot();
        protected virtual IList<TreeViewItem> BuildRows(TreeViewItem root);
        public void Reload();
        public void Repaint();
        protected Rect GetCellRectForTreeFoldouts(Rect rowRect);
        protected Rect GetRowRect(int row);
        public virtual IList<TreeViewItem> GetRows();
        protected IList<TreeViewItem> FindRows(IList<int> ids);
        protected TreeViewItem FindItem(int id, TreeViewItem searchFromThisItem);
        protected int FindRowOfItem(TreeViewItem item);
        protected void GetFirstAndLastVisibleRows(out int firstRowVisible, out int lastRowVisible);
        public void ExpandAll();
        public void CollapseAll();
        public void SetExpandedRecursive(int id, bool expanded);
        public bool SetExpanded(int id, bool expanded);
        public void SetExpanded(IList<int> ids);
        public IList<int> GetExpanded();
        public bool IsExpanded(int id);
        public IList<int> GetSelection();
        public void SetSelection(IList<int> selectedIDs);
        public void SetSelection(IList<int> selectedIDs, TreeViewSelectionOptions options);
        public bool IsSelected(int id);
        public bool HasSelection();
        public bool HasFocus();
        public void SetFocus();
        public void SetFocusAndEnsureSelectedItem();
        protected void SelectionClick(TreeViewItem item, bool keepMultiSelection);
        public bool BeginRename(TreeViewItem item);
        public bool BeginRename(TreeViewItem item, float delay);
        public void EndRename();
        public void FrameItem(int id);
        public virtual void OnGUI(Rect rect);
        public void SelectAllRows();
        protected float GetFoldoutIndent(TreeViewItem item);
        protected float GetContentIndent(TreeViewItem item);
        protected IList<int> SortItemIDsInRowOrder(IList<int> ids);
        protected void CenterRectUsingSingleLineHeight(ref Rect rect);
        protected void AddExpandedRows(TreeViewItem root, IList<TreeViewItem> rows);
        protected virtual void SelectionChanged(IList<int> selectedIds);
        protected virtual void SingleClickedItem(int id);
        protected virtual void DoubleClickedItem(int id);
        protected virtual void ContextClickedItem(int id);
        protected virtual void ContextClicked();
        protected virtual void ExpandedStateChanged();
        protected virtual void SearchChanged(string newSearch);
        protected virtual void KeyEvent();
        protected virtual IList<int> GetAncestors(int id);
        protected virtual IList<int> GetDescendantsThatHaveChildren(int id);
        protected virtual bool CanMultiSelect(TreeViewItem item);
        protected virtual bool CanRename(TreeViewItem item);
        protected virtual void RenameEnded(RenameEndedArgs args);
        protected virtual bool CanStartDrag(CanStartDragArgs args);
        protected virtual void SetupDragAndDrop(SetupDragAndDropArgs args);
        protected virtual DragAndDropVisualMode HandleDragAndDrop(DragAndDropArgs args);
        protected virtual bool CanBeParent(TreeViewItem item);
        protected virtual bool CanChangeExpandedState(TreeViewItem item);
        protected virtual bool DoesItemMatchSearch(TreeViewItem item, string search);
        protected virtual void RowGUI(RowGUIArgs args);
        protected virtual void BeforeRowsGUI();
        protected virtual void AfterRowsGUI();
        protected virtual void RefreshCustomRowHeights();
        protected virtual float GetCustomRowHeight(int row, TreeViewItem item);
        protected virtual Rect GetRenameRect(Rect rowRect, int row, TreeViewItem item);
        protected virtual void CommandEventHandling();
        protected static void SetupParentsAndChildrenFromDepths(TreeViewItem root, IList<TreeViewItem> rows);
        protected static void SetupDepthsFromParentsAndChildren(TreeViewItem root);
        protected static List<TreeViewItem> CreateChildListForCollapsedParent();
        protected static bool IsChildListForACollapsedParent(IList<TreeViewItem> childList);

        public delegate bool DoFoldoutCallback(Rect position, bool expandedState, GUIStyle style);
        public delegate List<int> GetNewSelectionFunction(TreeViewItem clickedItem, bool keepMultiSelection, bool useActionKeyAsShift);
        protected struct RowGUIArgs
        {
            public TreeViewItem item;
            public string label;
            public Rect rowRect;
            public int row;
            public bool selected;
            public bool focused;
            public bool isRenaming;

            public int GetNumVisibleColumns();
            public int GetColumn(int visibleColumnIndex);
            public Rect GetCellRect(int visibleColumnIndex);
        }
        protected struct DragAndDropArgs
        {
            public DragAndDropPosition dragAndDropPosition;
            public TreeViewItem parentItem;
            public int insertAtIndex;
            public bool performDrop;
        }
        protected struct SetupDragAndDropArgs
        {
            public IList<int> draggedItemIDs;
        }
        protected struct CanStartDragArgs
        {
            public TreeViewItem draggedItem;
            public IList<int> draggedItemIDs;
        }
        protected struct RenameEndedArgs
        {
            public bool acceptedRename;
            public int itemID;
            public string originalName;
            public string newName;
        }
        protected enum DragAndDropPosition
        {
            UponItem = 0,
            BetweenItems = 1,
            OutsideItems = 2
        }
        public static class DefaultGUI
        {
            public static void FoldoutLabel(Rect rect, string label, bool selected, bool focused);
            public static void Label(Rect rect, string label, bool selected, bool focused);
            public static void LabelRightAligned(Rect rect, string label, bool selected, bool focused);
            public static void BoldLabel(Rect rect, string label, bool selected, bool focused);
            public static void BoldLabelRightAligned(Rect rect, string label, bool selected, bool focused);
        }
        public static class DefaultStyles
        {
            public static GUIStyle foldoutLabel;
            public static GUIStyle label;
            public static GUIStyle labelRightAligned;
            public static GUIStyle boldLabel;
            public static GUIStyle boldLabelRightAligned;
            public static GUIStyle backgroundEven;
            public static GUIStyle backgroundOdd;
        }
    }
}

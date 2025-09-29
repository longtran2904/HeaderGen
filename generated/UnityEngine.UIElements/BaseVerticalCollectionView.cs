#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
    {
        public static readonly string ussClassName;
        public static readonly string borderUssClassName;
        public static readonly string itemUssClassName;
        public static readonly string dragHoverBarUssClassName;
        public static readonly string dragHoverMarkerUssClassName;
        public static readonly string itemDragHoverUssClassName;
        public static readonly string itemSelectedVariantUssClassName;
        public static readonly string itemAlternativeBackgroundUssClassName;
        public static readonly string listScrollViewUssClassName;

        public BaseVerticalCollectionView();
        public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1, Func<VisualElement> makeItem = null, Action<VisualElement, int> bindItem = null);

        public IList itemsSource { get; set; }
        public Func<VisualElement> makeItem { get; set; }
        public Action<VisualElement, int> bindItem { get; set; }
        public Action<VisualElement, int> unbindItem { get; set; }
        public Action<VisualElement> destroyItem { get; set; }
        public override VisualElement contentContainer { get; }
        public SelectionType selectionType { get; set; }
        public object selectedItem { get; }
        public IEnumerable<object> selectedItems { get; }
        public int selectedIndex { get; set; }
        public IEnumerable<int> selectedIndices { get; }
        [Obsolete("resolvedItemHeight is deprecated and will be removed from the API.", False)]
        public float resolvedItemHeight { get; }
        public bool showBorder { get; set; }
        public bool reorderable { get; set; }
        public bool horizontalScrollingEnabled { get; set; }
        public AlternatingRowBackground showAlternatingRowBackgrounds { get; set; }
        public CollectionVirtualizationMethod virtualizationMethod { get; set; }
        [Obsolete("itemHeight is deprecated, use fixedItemHeight instead.", False)]
        public int itemHeight { get; set; }
        public float fixedItemHeight { get; set; }

        [Obsolete("onItemChosen is deprecated, use onItemsChosen instead", True)]
        public event Action<object> onItemChosen;
        public event Action<IEnumerable<object>> onItemsChosen;
        [Obsolete("onSelectionChanged is deprecated, use onSelectionChange instead", True)]
        public event Action<List<object>> onSelectionChanged;
        public event Action<IEnumerable<object>> onSelectionChange;
        public event Action<IEnumerable<int>> onSelectedIndicesChange;
        public event Action<int, int> itemIndexChanged;
        public event Action itemsSourceChanged;

        public VisualElement GetRootElementForId(int id);
        public VisualElement GetRootElementForIndex(int index);
        public void RefreshItem(int index);
        public void RefreshItems();
        [Obsolete("Refresh() has been deprecated. Use Rebuild() instead. (UnityUpgradable) -> Rebuild()", False)]
        public void Refresh();
        public void Rebuild();
        public void ScrollTo(VisualElement visualElement);
        public void ScrollToItem(int index);
        public void ScrollToId(int id);
        [Obsolete("OnKeyDown is obsolete and will be removed from ListView. Use the event system instead, i.e. SendEvent(EventBase e).", False)]
        public void OnKeyDown(KeyDownEvent evt);
        public void AddToSelection(int index);
        public void RemoveFromSelection(int index);
        public void SetSelection(int index);
        public void SetSelection(IEnumerable<int> indices);
        public void SetSelectionWithoutNotify(IEnumerable<int> indices);
        public void ClearSelection();
        protected override void ExecuteDefaultAction(EventBase evt);
    }
}

#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class ListView : BaseVerticalCollectionView
    {
        public static readonly string ussClassName;
        public static readonly string itemUssClassName;
        public static readonly string emptyLabelUssClassName;
        public static readonly string reorderableUssClassName;
        public static readonly string reorderableItemUssClassName;
        public static readonly string reorderableItemContainerUssClassName;
        public static readonly string reorderableItemHandleUssClassName;
        public static readonly string reorderableItemHandleBarUssClassName;
        public static readonly string footerUssClassName;
        public static readonly string foldoutHeaderUssClassName;
        public static readonly string arraySizeFieldUssClassName;
        public static readonly string arraySizeFieldWithHeaderUssClassName;
        public static readonly string arraySizeFieldWithFooterUssClassName;
        public static readonly string listViewWithHeaderUssClassName;
        public static readonly string listViewWithFooterUssClassName;
        public static readonly string scrollViewWithFooterUssClassName;

        public ListView();
        public ListView(IList itemsSource, float itemHeight = -1, Func<VisualElement> makeItem = null, Action<VisualElement, int> bindItem = null);

        public bool showBoundCollectionSize { get; set; }
        public bool showFoldoutHeader { get; set; }
        public string headerTitle { get; set; }
        public bool showAddRemoveFooter { get; set; }
        public ListViewReorderMode reorderMode { get; set; }

        public event Action<IEnumerable<int>> itemsAdded;
        public event Action<IEnumerable<int>> itemsRemoved;

        public class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BindableElement.UxmlTraits
        {
            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}

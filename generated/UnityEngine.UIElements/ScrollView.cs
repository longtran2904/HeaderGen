#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class ScrollView : VisualElement
    {
        public static readonly string ussClassName;
        public static readonly string viewportUssClassName;
        public static readonly string contentAndVerticalScrollUssClassName;
        public static readonly string contentUssClassName;
        public static readonly string hScrollerUssClassName;
        public static readonly string vScrollerUssClassName;
        public static readonly string horizontalVariantUssClassName;
        public static readonly string verticalVariantUssClassName;
        public static readonly string verticalHorizontalVariantUssClassName;
        public static readonly string scrollVariantUssClassName;

        public ScrollView();
        public ScrollView(ScrollViewMode scrollViewMode);

        public ScrollerVisibility horizontalScrollerVisibility { get; set; }
        public ScrollerVisibility verticalScrollerVisibility { get; set; }
        [Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
        public bool showHorizontal { get; set; }
        [Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
        public bool showVertical { get; set; }
        public Vector2 scrollOffset { get; set; }
        public float horizontalPageSize { get; set; }
        public float verticalPageSize { get; set; }
        public float mouseWheelScrollSize { get; set; }
        public float scrollDecelerationRate { get; set; }
        public float elasticity { get; set; }
        public TouchScrollBehavior touchScrollBehavior { get; set; }
        public NestedInteractionKind nestedInteractionKind { get; set; }
        public long elasticAnimationIntervalMs { get; set; }
        public VisualElement contentViewport { get; }
        public Scroller horizontalScroller { get; }
        public Scroller verticalScroller { get; }
        public override VisualElement contentContainer { get; }
        public ScrollViewMode mode { get; set; }

        public void ScrollTo(VisualElement child);

        public class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
        public enum TouchScrollBehavior
        {
            Unrestricted = 0,
            Elastic = 1,
            Clamped = 2
        }
        public enum NestedInteractionKind
        {
            Default = 0,
            StopScrolling = 1,
            ForwardScrolling = 2
        }
    }
}

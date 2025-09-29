#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class TwoPaneSplitView : VisualElement
    {
        public TwoPaneSplitView();
        public TwoPaneSplitView(int fixedPaneIndex, float fixedPaneStartDimension, TwoPaneSplitViewOrientation orientation);

        public VisualElement fixedPane { get; }
        public VisualElement flexedPane { get; }
        public int fixedPaneIndex { get; set; }
        public float fixedPaneInitialDimension { get; set; }
        public TwoPaneSplitViewOrientation orientation { get; set; }
        public override VisualElement contentContainer { get; }

        public void CollapseChild(int index);
        public void UnCollapse();

        public class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {
            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}

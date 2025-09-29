#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
    [DefaultMember("Item")]
    public class VisualElement : Focusable, IExperimentalFeatures, IResolvedStyle, IStylePropertyAnimations, ITransform, ITransitionAnimations, IVisualElementScheduler
    {

        public static readonly string disabledUssClassName;

        public VisualElement();

        public VisualElement this[int key] { get; }
        public string viewDataKey { get; set; }
        public object userData { get; set; }
        public override bool canGrabFocus { get; }
        public override FocusController focusController { get; }
        public UsageHints usageHints { get; set; }
        public ITransform transform { get; }
        public Rect layout { get; }
        public Rect contentRect { get; }
        protected Rect paddingRect { get; }
        public Rect worldBound { get; }
        public Rect localBound { get; }
        public Matrix4x4 worldTransform { get; }
        public PickingMode pickingMode { get; set; }
        public string name { get; set; }
        public bool enabledInHierarchy { get; }
        public bool enabledSelf { get; }
        public bool visible { get; set; }
        public Action<MeshGenerationContext> generateVisualContent { get; set; }
        public IExperimentalFeatures experimental { get; }
        public Hierarchy hierarchy { get; }
        [Obsolete("VisualElement.cacheAsBitmap is deprecated and has no effect")]
        public bool cacheAsBitmap { get; set; }
        public VisualElement parent { get; }
        public IPanel panel { get; }
        public virtual VisualElement contentContainer { get; }
        public VisualTreeAsset visualTreeAssetSource { get; }
        public int childCount { get; }
        public IVisualElementScheduler schedule { get; }
        public IStyle style { get; }
        public ICustomStyle customStyle { get; }
        public VisualElementStyleSheetSet styleSheets { get; }
        public string tooltip { get; set; }
        public IResolvedStyle resolvedStyle { get; }

        protected override void ExecuteDefaultAction(EventBase evt);
        public sealed override void Focus();
        public sealed override void SendEvent(EventBase e);
        [Obsolete("SetEnabledFromHierarchy is deprecated and will be removed in a future release. Please use SetEnabled instead.")]
        protected internal bool SetEnabledFromHierarchy(bool state);
        public void SetEnabled(bool value);
        public void MarkDirtyRepaint();
        public virtual bool ContainsPoint(Vector2 localPoint);
        public virtual bool Overlaps(Rect rectangle);
        protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode);
        public override string ToString();
        public IEnumerable<string> GetClasses();
        public void ClearClassList();
        public void AddToClassList(string className);
        public void RemoveFromClassList(string className);
        public void ToggleInClassList(string className);
        public void EnableInClassList(string className, bool enable);
        public bool ClassListContains(string cls);
        public object FindAncestorUserData();
        public void Add(VisualElement child);
        public void Insert(int index, VisualElement element);
        public void Remove(VisualElement element);
        public void RemoveAt(int index);
        public void Clear();
        public VisualElement ElementAt(int index);
        public int IndexOf(VisualElement element);
        public IEnumerable<VisualElement> Children();
        public void Sort(Comparison<VisualElement> comp);
        public void BringToFront();
        public void SendToBack();
        public void PlaceBehind(VisualElement sibling);
        public void PlaceInFront(VisualElement sibling);
        public void RemoveFromHierarchy();
        public T GetFirstOfType<T>() where T : class;
        public T GetFirstAncestorOfType<T>() where T : class;
        public bool Contains(VisualElement child);
        public VisualElement FindCommonAncestor(VisualElement other);
        public class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : UIElements.UxmlTraits
        {

            protected UxmlStringAttributeDescription m_Name;
            protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode;

            public UxmlTraits();

            protected UxmlIntAttributeDescription focusIndex { get; set; }
            protected UxmlBoolAttributeDescription focusable { get; set; }
            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
        public enum MeasureMode
        {

            Undefined = 0,
            Exactly = 1,
            AtMost = 2
        }
        [DefaultMember("Item")]
        public struct Hierarchy
        {

            public VisualElement this[int key] { get; }
            public VisualElement parent { get; }
            public int childCount { get; }

            public void Add(VisualElement child);
            public void Insert(int index, VisualElement child);
            public void Remove(VisualElement child);
            public void RemoveAt(int index);
            public void Clear();
            public int IndexOf(VisualElement element);
            public VisualElement ElementAt(int index);
            public IEnumerable<VisualElement> Children();
            public void Sort(Comparison<VisualElement> comp);
            public bool Equals(Hierarchy other);
            public override bool Equals(object obj);
            public override int GetHashCode();

            public static bool operator ==(Hierarchy x, Hierarchy y);
            public static bool operator !=(Hierarchy x, Hierarchy y);
        }
    }
}

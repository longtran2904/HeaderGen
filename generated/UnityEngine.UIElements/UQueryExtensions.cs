#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public static class UQueryExtensions
    {
        public static T Q<T>(this VisualElement e, string name = null, params string[] classes) where T : VisualElement;
        public static VisualElement Q(this VisualElement e, string name = null, params string[] classes);
        public static T Q<T>(this VisualElement e, string name = null, string className = null) where T : VisualElement;
        public static VisualElement Q(this VisualElement e, string name = null, string className = null);
        public static UQueryBuilder<VisualElement> Query(this VisualElement e, string name = null, params string[] classes);
        public static UQueryBuilder<VisualElement> Query(this VisualElement e, string name = null, string className = null);
        public static UQueryBuilder<T> Query<T>(this VisualElement e, string name = null, params string[] classes) where T : VisualElement;
        public static UQueryBuilder<T> Query<T>(this VisualElement e, string name = null, string className = null) where T : VisualElement;
        public static UQueryBuilder<VisualElement> Query(this VisualElement e);
    }
}

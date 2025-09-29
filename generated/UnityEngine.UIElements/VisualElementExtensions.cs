#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public static class VisualElementExtensions
    {
        public static void StretchToParentSize(this VisualElement elem);
        public static void StretchToParentWidth(this VisualElement elem);
        public static void AddManipulator(this VisualElement ele, IManipulator manipulator);
        public static void RemoveManipulator(this VisualElement ele, IManipulator manipulator);
        public static Vector2 WorldToLocal(this VisualElement ele, Vector2 p);
        public static Vector2 LocalToWorld(this VisualElement ele, Vector2 p);
        public static Rect WorldToLocal(this VisualElement ele, Rect r);
        public static Rect LocalToWorld(this VisualElement ele, Rect r);
        public static Vector2 ChangeCoordinatesTo(this VisualElement src, VisualElement dest, Vector2 point);
        public static Rect ChangeCoordinatesTo(this VisualElement src, VisualElement dest, Rect rect);
    }
}

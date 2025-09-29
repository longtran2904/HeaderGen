#region UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Camera/Camera.h")]
    [NativeHeader("Modules/UI/Canvas.h")]
    [NativeHeader("Modules/UI/RectTransformUtil.h")]
    [NativeHeader("Runtime/Transform/RectTransform.h")]
    [StaticAccessor("UI", StaticAccessorType.DoubleColon)]
    public sealed class RectTransformUtility
    {

        public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas);
        public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas);
        public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint);
        public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam);
        public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset);
        public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint);
        public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint);
        public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos);
        public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint);
        public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child);
        public static Bounds CalculateRelativeRectTransformBounds(Transform trans);
        public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive);
        public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive);
    }
}

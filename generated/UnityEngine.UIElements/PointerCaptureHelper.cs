#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public static class PointerCaptureHelper
    {

        public static bool HasPointerCapture(this IEventHandler handler, int pointerId);
        public static void CapturePointer(this IEventHandler handler, int pointerId);
        public static void ReleasePointer(this IEventHandler handler, int pointerId);
        public static IEventHandler GetCapturingElement(this IPanel panel, int pointerId);
        public static void ReleasePointer(this IPanel panel, int pointerId);
    }
}

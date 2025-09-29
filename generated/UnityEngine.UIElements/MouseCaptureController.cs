#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public static class MouseCaptureController
    {
        public static bool IsMouseCaptured();
        public static bool HasMouseCapture(this IEventHandler handler);
        public static void CaptureMouse(this IEventHandler handler);
        public static void ReleaseMouse(this IEventHandler handler);
        public static void ReleaseMouse();
    }
}

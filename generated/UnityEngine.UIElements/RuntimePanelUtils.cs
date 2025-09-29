#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public static class RuntimePanelUtils
    {

        public static Vector2 ScreenToPanel(IPanel panel, Vector2 screenPosition);
        public static Vector2 CameraTransformWorldToPanel(IPanel panel, Vector3 worldPosition, Camera camera);
        public static Rect CameraTransformWorldToPanelRect(IPanel panel, Vector3 worldPosition, Vector2 worldSize, Camera camera);
        public static void ResetDynamicAtlas(this IPanel panel);
        public static void SetTextureDirty(this IPanel panel, Texture2D texture);
    }
}

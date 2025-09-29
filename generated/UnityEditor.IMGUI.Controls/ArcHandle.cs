#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class ArcHandle
    {
        public ArcHandle();

        ~ArcHandle();

        public float angle { get; set; }
        public float radius { get; set; }
        public Color angleHandleColor { get; set; }
        public Color radiusHandleColor { get; set; }
        public Color fillColor { get; set; }
        public Color wireframeColor { get; set; }
        public Handles.CapFunction angleHandleDrawFunction { get; set; }
        public Handles.SizeFunction angleHandleSizeFunction { get; set; }
        public Handles.CapFunction radiusHandleDrawFunction { get; set; }
        public Handles.SizeFunction radiusHandleSizeFunction { get; set; }

        public static void DefaultAngleHandleDrawFunction(int controlID, Vector3 position, Quaternion rotation, float size, EventType eventType);
        public static float DefaultAngleHandleSizeFunction(Vector3 position);
        public static float DefaultRadiusHandleSizeFunction(Vector3 position);
        public void SetColorWithoutRadiusHandle(Color color, float fillColorAlpha);
        public void SetColorWithRadiusHandle(Color color, float fillColorAlpha);
        public void DrawHandle();
    }
}

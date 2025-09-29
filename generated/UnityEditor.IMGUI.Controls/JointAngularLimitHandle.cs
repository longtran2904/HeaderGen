#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class JointAngularLimitHandle
    {

        public JointAngularLimitHandle();

        public float xMin { get; set; }
        public float xMax { get; set; }
        public float yMin { get; set; }
        public float yMax { get; set; }
        public float zMin { get; set; }
        public float zMax { get; set; }
        public Vector2 xRange { get; set; }
        public Vector2 yRange { get; set; }
        public Vector2 zRange { get; set; }
        public ConfigurableJointMotion xMotion { get; set; }
        public ConfigurableJointMotion yMotion { get; set; }
        public ConfigurableJointMotion zMotion { get; set; }
        public Color xHandleColor { get; set; }
        public Color yHandleColor { get; set; }
        public Color zHandleColor { get; set; }
        public float radius { get; set; }
        public float fillAlpha { get; set; }
        public float wireframeAlpha { get; set; }
        public Handles.CapFunction angleHandleDrawFunction { get; set; }
        public Handles.SizeFunction angleHandleSizeFunction { get; set; }

        public void DrawHandle();
        public void DrawHandle(bool usingArticulations);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("UI::RectTransform")]
    [NativeHeader("Runtime/Transform/RectTransform.h")]
    public sealed class RectTransform : Transform
    {

        public RectTransform();

        public Rect rect { get; }
        public Vector2 anchorMin { get; set; }
        public Vector2 anchorMax { get; set; }
        public Vector2 anchoredPosition { get; set; }
        public Vector2 sizeDelta { get; set; }
        public Vector2 pivot { get; set; }
        public Vector3 anchoredPosition3D { get; set; }
        public Vector2 offsetMin { get; set; }
        public Vector2 offsetMax { get; set; }
        public Object drivenByObject { get; }

        public static event ReapplyDrivenProperties reapplyDrivenProperties;

        [NativeMethod("UpdateIfTransformDispatchIsDirty")]
        public void ForceUpdateRectTransforms();
        public void GetLocalCorners(Vector3[] fourCornersArray);
        public void GetWorldCorners(Vector3[] fourCornersArray);
        public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size);
        public void SetSizeWithCurrentAnchors(Axis axis, float size);
        public enum Edge
        {

            Left = 0,
            Right = 1,
            Top = 2,
            Bottom = 3
        }
        public enum Axis
        {

            Horizontal = 0,
            Vertical = 1
        }
        public delegate void ReapplyDrivenProperties(RectTransform driven);
    }
}

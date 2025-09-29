#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/LineRenderer.h")]
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    public sealed class LineRenderer : Renderer
    {

        public LineRenderer();

        [Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", False)]
        public int numPositions { get; set; }
        public float startWidth { get; set; }
        public float endWidth { get; set; }
        public float widthMultiplier { get; set; }
        public int numCornerVertices { get; set; }
        public int numCapVertices { get; set; }
        public bool useWorldSpace { get; set; }
        public bool loop { get; set; }
        public Color startColor { get; set; }
        public Color endColor { get; set; }
        [NativeProperty("PositionsCount")]
        public int positionCount { get; set; }
        public float shadowBias { get; set; }
        public bool generateLightingData { get; set; }
        public LineTextureMode textureMode { get; set; }
        public LineAlignment alignment { get; set; }
        public AnimationCurve widthCurve { get; set; }
        public Gradient colorGradient { get; set; }

        [Obsolete("Use startWidth, endWidth or widthCurve instead.", False)]
        public void SetWidth(float start, float end);
        [Obsolete("Use startColor, endColor or colorGradient instead.", False)]
        public void SetColors(Color start, Color end);
        [Obsolete("Use positionCount instead.", False)]
        public void SetVertexCount(int count);
        public void SetPosition(int index, Vector3 position);
        public Vector3 GetPosition(int index);
        public void Simplify(float tolerance);
        public void BakeMesh(Mesh mesh, bool useTransform = False);
        public void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = False);
        [FreeFunction(Name = "LineRendererScripting::GetPositions", HasExplicitThis = True)]
        public int GetPositions([NotNull("ArgumentNullException")] out Vector3[] positions);
        [FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = True)]
        public void SetPositions([NotNull("ArgumentNullException")] Vector3[] positions);
        public void SetPositions(NativeArray<Vector3> positions);
        public void SetPositions(NativeSlice<Vector3> positions);
        public int GetPositions(out NativeArray<Vector3> positions);
        public int GetPositions(out NativeSlice<Vector3> positions);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/TrailRenderer.h")]
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    public sealed class TrailRenderer : Renderer
    {
        public TrailRenderer();

        [Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", False)]
        public int numPositions { get; }
        public float time { get; set; }
        public float startWidth { get; set; }
        public float endWidth { get; set; }
        public float widthMultiplier { get; set; }
        public bool autodestruct { get; set; }
        public bool emitting { get; set; }
        public int numCornerVertices { get; set; }
        public int numCapVertices { get; set; }
        public float minVertexDistance { get; set; }
        public Color startColor { get; set; }
        public Color endColor { get; set; }
        [NativeProperty("PositionsCount")]
        public int positionCount { get; }
        public float shadowBias { get; set; }
        public bool generateLightingData { get; set; }
        public LineTextureMode textureMode { get; set; }
        public LineAlignment alignment { get; set; }
        public AnimationCurve widthCurve { get; set; }
        public Gradient colorGradient { get; set; }

        public void SetPosition(int index, Vector3 position);
        public Vector3 GetPosition(int index);
        public void Clear();
        public void BakeMesh(Mesh mesh, bool useTransform = False);
        public void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = False);
        [FreeFunction(Name = "TrailRendererScripting::GetPositions", HasExplicitThis = True)]
        public int GetPositions([NotNull("ArgumentNullException")] out Vector3[] positions);
        [FreeFunction(Name = "TrailRendererScripting::GetVisiblePositions", HasExplicitThis = True)]
        public int GetVisiblePositions([NotNull("ArgumentNullException")] out Vector3[] positions);
        [FreeFunction(Name = "TrailRendererScripting::SetPositions", HasExplicitThis = True)]
        public void SetPositions([NotNull("ArgumentNullException")] Vector3[] positions);
        [FreeFunction(Name = "TrailRendererScripting::AddPosition", HasExplicitThis = True)]
        public void AddPosition(Vector3 position);
        [FreeFunction(Name = "TrailRendererScripting::AddPositions", HasExplicitThis = True)]
        public void AddPositions([NotNull("ArgumentNullException")] Vector3[] positions);
        public void SetPositions(NativeArray<Vector3> positions);
        public void SetPositions(NativeSlice<Vector3> positions);
        public int GetPositions(out NativeArray<Vector3> positions);
        public int GetPositions(out NativeSlice<Vector3> positions);
        public int GetVisiblePositions(out NativeArray<Vector3> positions);
        public int GetVisiblePositions(out NativeSlice<Vector3> positions);
        public void AddPositions(out NativeArray<Vector3> positions);
        public void AddPositions(out NativeSlice<Vector3> positions);
    }
}

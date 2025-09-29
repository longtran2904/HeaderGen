#region UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("UI::CanvasRenderer")]
    [NativeHeader("Modules/UI/CanvasRenderer.h")]
    public sealed class CanvasRenderer : Component
    {

        public CanvasRenderer();

        public bool hasPopInstruction { get; set; }
        public int materialCount { get; set; }
        public int popMaterialCount { get; set; }
        public int absoluteDepth { get; }
        public bool hasMoved { get; }
        public bool cullTransparentMesh { get; set; }
        [NativeProperty("RectClipping", False, TargetType.Function)]
        public bool hasRectClipping { get; }
        [NativeProperty("Depth", False, TargetType.Function)]
        public int relativeDepth { get; }
        [NativeProperty("ShouldCull", False, TargetType.Function)]
        public bool cull { get; set; }
        [Obsolete("isMask is no longer supported.See EnableClipping for vertex clipping configuration", False)]
        public bool isMask { get; set; }
        public Vector2 clippingSoftness { get; set; }

        public static event OnRequestRebuild onRequestRebuild;

        public void SetColor(Color color);
        public Color GetColor();
        public void EnableRectClipping(Rect rect);
        public void DisableRectClipping();
        public void SetMaterial(Material material, int index);
        public Material GetMaterial(int index);
        public void SetPopMaterial(Material material, int index);
        public Material GetPopMaterial(int index);
        public void SetTexture(Texture texture);
        public void SetAlphaTexture(Texture texture);
        public void SetMesh(Mesh mesh);
        public void Clear();
        public float GetAlpha();
        public void SetAlpha(float alpha);
        public float GetInheritedAlpha();
        public void SetMaterial(Material material, Texture texture);
        public Material GetMaterial();
        public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);
        public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);
        public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);
        public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices);
        public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents);
        public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents);
        [Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
        public void SetVertices(List<UIVertex> vertices);
        [Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
        public void SetVertices(UIVertex[] vertices, int size);
        public delegate void OnRequestRebuild();
    }
}

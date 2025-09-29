#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
    [AddComponentMenu("Mesh/TextMeshPro - Text")]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
    [RequireComponent(typeof(MeshRenderer))]
    public class TextMeshPro : TMP_Text, ILayoutElement
    {
        public TextMeshPro();

        public int sortingLayerID { get; set; }
        public int sortingOrder { get; set; }
        public override bool autoSizeTextContainer { get; set; }
        [Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
        public TextContainer textContainer { get; }
        public Transform transform { get; }
        public Renderer renderer { get; }
        public override Mesh mesh { get; }
        public MeshFilter meshFilter { get; }
        public MaskingTypes maskType { get; set; }

        public override event Action<TMP_TextInfo> OnPreRenderText;

        public void SetMask(MaskingTypes type, Vector4 maskCoords);
        public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY);
        public override void SetVerticesDirty();
        public override void SetLayoutDirty();
        public override void SetMaterialDirty();
        public override void SetAllDirty();
        public override void Rebuild(CanvasUpdate update);
        protected override void UpdateMaterial();
        public override void UpdateMeshPadding();
        public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False);
        public override TMP_TextInfo GetTextInfo(string text);
        public override void ClearMesh(bool updateMesh);
        public override void UpdateGeometry(Mesh mesh, int index);
        public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags);
        public override void UpdateVertexData();
        public void UpdateFontAsset();
        public void CalculateLayoutInputHorizontal();
        public void CalculateLayoutInputVertical();
        protected override void Awake();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDestroy();
        protected override void Reset();
        protected override void OnValidate();
        protected override void LoadFontAsset();
        protected override Material GetMaterial(Material mat);
        protected override Material[] GetMaterials(Material[] mats);
        protected override void SetSharedMaterial(Material mat);
        protected override Material[] GetSharedMaterials();
        protected override void SetSharedMaterials(Material[] materials);
        protected override void SetOutlineThickness(float thickness);
        protected override void SetFaceColor(Color32 color);
        protected override void SetOutlineColor(Color32 color);
        protected override void SetShaderDepth();
        protected override void SetCulling();
        public override void ComputeMarginSize();
        protected override void OnDidApplyAnimationProperties();
        protected override void OnTransformParentChanged();
        protected override void OnRectTransformDimensionsChange();
        protected virtual void GenerateTextMesh();
        protected override Vector3[] GetTextContainerLocalCorners();
        protected override void SetActiveSubMeshes(bool state);
        protected void SetActiveSubTextObjectRenderers(bool state);
        protected override void DestroySubMeshObjects();
        protected override Bounds GetCompoundBounds();
    }
}

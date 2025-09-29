#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
    [AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(CanvasRenderer))]
    public class TextMeshProUGUI : TMP_Text, ILayoutElement
    {
        protected TMP_SubMeshUI[] m_subTextObjects;

        public TextMeshProUGUI();

        public override Material materialForRendering { get; }
        public override bool autoSizeTextContainer { get; set; }
        public override Mesh mesh { get; }
        public CanvasRenderer canvasRenderer { get; }
        public Vector4 maskOffset { get; set; }

        public override event Action<TMP_TextInfo> OnPreRenderText;

        public void CalculateLayoutInputHorizontal();
        public void CalculateLayoutInputVertical();
        public override void SetVerticesDirty();
        public override void SetLayoutDirty();
        public override void SetMaterialDirty();
        public override void SetAllDirty();
        public override void Rebuild(CanvasUpdate update);
        public override Material GetModifiedMaterial(Material baseMaterial);
        protected override void UpdateMaterial();
        public override void RecalculateClipping();
        public override void Cull(Rect clipRect, bool validRect);
        public override void UpdateMeshPadding();
        protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
        protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
        public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False);
        public override TMP_TextInfo GetTextInfo(string text);
        public override void ClearMesh();
        public override void UpdateGeometry(Mesh mesh, int index);
        public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags);
        public override void UpdateVertexData();
        public void UpdateFontAsset();
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
        protected override void OnCanvasHierarchyChanged();
        protected override void OnTransformParentChanged();
        protected override void OnRectTransformDimensionsChange();
        protected virtual void GenerateTextMesh();
        protected override Vector3[] GetTextContainerLocalCorners();
        protected override void SetActiveSubMeshes(bool state);
        protected override void DestroySubMeshObjects();
        protected override Bounds GetCompoundBounds();
    }
}

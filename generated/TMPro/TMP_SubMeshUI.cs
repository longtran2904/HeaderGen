#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
    [ExecuteAlways]
    [RequireComponent(typeof(CanvasRenderer))]
    public class TMP_SubMeshUI : MaskableGraphic
    {
        public TMP_SubMeshUI();

        public TMP_FontAsset fontAsset { get; set; }
        public TMP_SpriteAsset spriteAsset { get; set; }
        public override Texture mainTexture { get; }
        public override Material material { get; set; }
        public Material sharedMaterial { get; set; }
        public Material fallbackMaterial { get; set; }
        public Material fallbackSourceMaterial { get; set; }
        public override Material materialForRendering { get; }
        public bool isDefaultMaterial { get; set; }
        public float padding { get; set; }
        public Mesh mesh { get; set; }
        public TMP_Text textComponent { get; }

        public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference);
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDestroy();
        protected override void OnTransformParentChanged();
        public override Material GetModifiedMaterial(Material baseMaterial);
        public float GetPaddingForMaterial();
        public float GetPaddingForMaterial(Material mat);
        public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        public override void SetAllDirty();
        public override void SetVerticesDirty();
        public override void SetLayoutDirty();
        public override void SetMaterialDirty();
        public void SetPivotDirty();
        public override void Cull(Rect clipRect, bool validRect);
        protected override void UpdateGeometry();
        public override void Rebuild(CanvasUpdate update);
        public void RefreshMaterial();
        protected override void UpdateMaterial();
        public override void RecalculateClipping();
    }
}

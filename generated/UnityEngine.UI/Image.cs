#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Image", 11)]
    [RequireComponent(typeof(CanvasRenderer))]
    public class Image : MaskableGraphic, ICanvasRaycastFilter, ILayoutElement, ISerializationCallbackReceiver
    {

        protected static Material s_ETC1DefaultUI;

        protected Image();

        public Sprite sprite { get; set; }
        public Sprite overrideSprite { get; set; }
        public Type type { get; set; }
        public bool preserveAspect { get; set; }
        public bool fillCenter { get; set; }
        public FillMethod fillMethod { get; set; }
        public float fillAmount { get; set; }
        public bool fillClockwise { get; set; }
        public int fillOrigin { get; set; }
        [Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
        public float eventAlphaThreshold { get; set; }
        public float alphaHitTestMinimumThreshold { get; set; }
        public bool useSpriteMesh { get; set; }
        public static Material defaultETC1GraphicMaterial { get; }
        public override Texture mainTexture { get; }
        public bool hasBorder { get; }
        public float pixelsPerUnitMultiplier { get; set; }
        public float pixelsPerUnit { get; }
        protected float multipliedPixelsPerUnit { get; }
        public override Material material { get; set; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }

        public void DisableSpriteOptimizations();
        public virtual void OnBeforeSerialize();
        public virtual void OnAfterDeserialize();
        public override void SetNativeSize();
        protected override void OnPopulateMesh(VertexHelper toFill);
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void UpdateMaterial();
        protected override void OnCanvasHierarchyChanged();
        public virtual void CalculateLayoutInputHorizontal();
        public virtual void CalculateLayoutInputVertical();
        public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera);
        protected override void OnDidApplyAnimationProperties();
        protected override void OnValidate();
        public enum Type
        {

            Simple = 0,
            Sliced = 1,
            Tiled = 2,
            Filled = 3
        }
        public enum FillMethod
        {

            Horizontal = 0,
            Vertical = 1,
            Radial90 = 2,
            Radial180 = 3,
            Radial360 = 4
        }
        public enum OriginHorizontal
        {

            Left = 0,
            Right = 1
        }
        public enum OriginVertical
        {

            Bottom = 0,
            Top = 1
        }
        public enum Origin90
        {

            BottomLeft = 0,
            TopLeft = 1,
            TopRight = 2,
            BottomRight = 3
        }
        public enum Origin180
        {

            Bottom = 0,
            Left = 1,
            Top = 2,
            Right = 3
        }
        public enum Origin360
        {

            Bottom = 0,
            Right = 1,
            Top = 2,
            Left = 3
        }
    }
}

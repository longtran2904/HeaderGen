#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("Layout/Canvas Scaler", 101)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [RequireComponent(typeof(Canvas))]
    public class CanvasScaler : UIBehaviour
    {
        [SerializeField]
        [Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
        protected float m_ReferencePixelsPerUnit;
        [SerializeField]
        [Tooltip("Scales all UI elements in the Canvas by this factor.")]
        protected float m_ScaleFactor;
        [SerializeField]
        [Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
        protected Vector2 m_ReferenceResolution;
        [SerializeField]
        [Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
        protected ScreenMatchMode m_ScreenMatchMode;
        [Range(0, 1)]
        [SerializeField]
        [Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
        protected float m_MatchWidthOrHeight;
        [SerializeField]
        [Tooltip("The physical unit to specify positions and sizes in.")]
        protected Unit m_PhysicalUnit;
        [SerializeField]
        [Tooltip("The DPI to assume if the screen DPI is not known.")]
        protected float m_FallbackScreenDPI;
        [SerializeField]
        [Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
        protected float m_DefaultSpriteDPI;
        [SerializeField]
        [Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
        protected float m_DynamicPixelsPerUnit;
        [SerializeField]
        protected bool m_PresetInfoIsWorld;

        protected CanvasScaler();

        public ScaleMode uiScaleMode { get; set; }
        public float referencePixelsPerUnit { get; set; }
        public float scaleFactor { get; set; }
        public Vector2 referenceResolution { get; set; }
        public ScreenMatchMode screenMatchMode { get; set; }
        public float matchWidthOrHeight { get; set; }
        public Unit physicalUnit { get; set; }
        public float fallbackScreenDPI { get; set; }
        public float defaultSpriteDPI { get; set; }
        public float dynamicPixelsPerUnit { get; set; }

        protected override void OnEnable();
        protected override void OnDisable();
        protected virtual void Handle();
        protected virtual void HandleWorldCanvas();
        protected virtual void HandleConstantPixelSize();
        protected virtual void HandleScaleWithScreenSize();
        protected virtual void HandleConstantPhysicalSize();
        protected void SetScaleFactor(float scaleFactor);
        protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit);
        protected override void OnValidate();

        public enum ScaleMode
        {
            ConstantPixelSize = 0,
            ScaleWithScreenSize = 1,
            ConstantPhysicalSize = 2
        }
        public enum ScreenMatchMode
        {
            MatchWidthOrHeight = 0,
            Expand = 1,
            Shrink = 2
        }
        public enum Unit
        {
            Centimeters = 0,
            Millimeters = 1,
            Inches = 2,
            Points = 3,
            Picas = 4
        }
    }
}

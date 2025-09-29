#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Legacy/Text", 100)]
    [RequireComponent(typeof(CanvasRenderer))]
    public class Text : MaskableGraphic, ILayoutElement
    {

        [SerializeField]
        [TextArea(3, 10)]
        protected string m_Text;
        [NonSerialized]
        protected bool m_DisableFontTextureRebuiltCallback;
        protected static Material s_DefaultText;

        protected Text();

        public TextGenerator cachedTextGenerator { get; }
        public TextGenerator cachedTextGeneratorForLayout { get; }
        public override Texture mainTexture { get; }
        public Font font { get; set; }
        public virtual string text { get; set; }
        public bool supportRichText { get; set; }
        public bool resizeTextForBestFit { get; set; }
        public int resizeTextMinSize { get; set; }
        public int resizeTextMaxSize { get; set; }
        public TextAnchor alignment { get; set; }
        public bool alignByGeometry { get; set; }
        public int fontSize { get; set; }
        public HorizontalWrapMode horizontalOverflow { get; set; }
        public VerticalWrapMode verticalOverflow { get; set; }
        public float lineSpacing { get; set; }
        public FontStyle fontStyle { get; set; }
        public float pixelsPerUnit { get; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }

        public void FontTextureChanged();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void UpdateGeometry();
        protected override void Reset();
        public TextGenerationSettings GetGenerationSettings(Vector2 extents);
        public static Vector2 GetTextAnchorPivot(TextAnchor anchor);
        protected override void OnPopulateMesh(VertexHelper toFill);
        public virtual void CalculateLayoutInputHorizontal();
        public virtual void CalculateLayoutInputVertical();
        public override void OnRebuildRequested();
        protected override void OnValidate();
    }
}

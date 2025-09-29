#region UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
    public sealed class GUIText
    {
        public GUIText();

        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public bool text { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public Material material { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public Font font { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public TextAlignment alignment { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public TextAnchor anchor { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public float lineSpacing { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public float tabSize { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public int fontSize { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public FontStyle fontStyle { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public bool richText { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public Color color { get; set; }
        [Obsolete("GUIText has been removed. Use UI.Text instead.", True)]
        public Vector2 pixelOffset { get; set; }
    }
}

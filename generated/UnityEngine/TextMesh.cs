#region UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeClass("TextRenderingPrivate::TextMesh")]
    [NativeHeader("Modules/TextRendering/Public/TextMesh.h")]
    [RequireComponent(typeof(Transform), typeof(MeshRenderer))]
    public sealed class TextMesh : Component
    {

        public TextMesh();

        public string text { get; set; }
        public Font font { get; set; }
        public int fontSize { get; set; }
        public FontStyle fontStyle { get; set; }
        public float offsetZ { get; set; }
        public TextAlignment alignment { get; set; }
        public TextAnchor anchor { get; set; }
        public float characterSize { get; set; }
        public float lineSpacing { get; set; }
        public float tabSize { get; set; }
        public bool richText { get; set; }
        public Color color { get; set; }
    }
}

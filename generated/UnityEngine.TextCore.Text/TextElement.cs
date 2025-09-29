#region UnityEngine.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextCoreTextEngineModule.dll
#endregion

namespace UnityEngine.TextCore.Text
{
    public abstract class TextElement
    {

        [SerializeField]
        protected TextElementType m_ElementType;

        protected TextElement();

        public TextElementType elementType { get; }
        public uint unicode { get; set; }
        public TextAsset textAsset { get; set; }
        public Glyph glyph { get; set; }
        public uint glyphIndex { get; set; }
        public float scale { get; set; }
    }
}

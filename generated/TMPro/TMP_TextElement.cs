#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
    public class TMP_TextElement
    {

        [SerializeField]
        protected TextElementType m_ElementType;

        public TMP_TextElement();

        public TextElementType elementType { get; }
        public uint unicode { get; set; }
        public TMP_Asset textAsset { get; set; }
        public Glyph glyph { get; set; }
        public uint glyphIndex { get; set; }
        public float scale { get; set; }
    }
}

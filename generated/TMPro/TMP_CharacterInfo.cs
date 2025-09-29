#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    public struct TMP_CharacterInfo
    {
        public char character;
        public int index;
        public int stringLength;
        public TMP_TextElementType elementType;
        public TMP_TextElement textElement;
        public TMP_FontAsset fontAsset;
        public TMP_SpriteAsset spriteAsset;
        public int spriteIndex;
        public Material material;
        public int materialReferenceIndex;
        public bool isUsingAlternateTypeface;
        public float pointSize;
        public int lineNumber;
        public int pageNumber;
        public int vertexIndex;
        public TMP_Vertex vertex_BL;
        public TMP_Vertex vertex_TL;
        public TMP_Vertex vertex_TR;
        public TMP_Vertex vertex_BR;
        public Vector3 topLeft;
        public Vector3 bottomLeft;
        public Vector3 topRight;
        public Vector3 bottomRight;
        public float origin;
        public float xAdvance;
        public float ascender;
        public float baseLine;
        public float descender;
        public float aspectRatio;
        public float scale;
        public Color32 color;
        public Color32 underlineColor;
        public int underlineVertexIndex;
        public Color32 strikethroughColor;
        public int strikethroughVertexIndex;
        public Color32 highlightColor;
        public HighlightState highlightState;
        public FontStyles style;
        public bool isVisible;
    }
}

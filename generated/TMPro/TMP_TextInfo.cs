#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public class TMP_TextInfo
    {
        public TMP_Text textComponent;
        public int characterCount;
        public int spriteCount;
        public int spaceCount;
        public int wordCount;
        public int linkCount;
        public int lineCount;
        public int pageCount;
        public int materialCount;
        public TMP_CharacterInfo[] characterInfo;
        public TMP_WordInfo[] wordInfo;
        public TMP_LinkInfo[] linkInfo;
        public TMP_LineInfo[] lineInfo;
        public TMP_PageInfo[] pageInfo;
        public TMP_MeshInfo[] meshInfo;

        public TMP_TextInfo();
        public TMP_TextInfo(TMP_Text textComponent);

        public void Clear();
        public void ClearMeshInfo(bool updateMesh);
        public void ClearAllMeshInfo();
        public void ResetVertexLayout(bool isVolumetric);
        public void ClearUnusedVertices(MaterialReference[] materials);
        public void ClearLineInfo();
        public TMP_MeshInfo[] CopyMeshInfoVertexData();
        public static void Resize<T>(ref T[] array, int size);
        public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
    }
}

#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    [ExecuteAlways]
    [RequireComponent(typeof(MeshRenderer))]
    public class TMP_SubMesh : MonoBehaviour
    {

        public TMP_SubMesh();

        public TMP_FontAsset fontAsset { get; set; }
        public TMP_SpriteAsset spriteAsset { get; set; }
        public Material material { get; set; }
        public Material sharedMaterial { get; set; }
        public Material fallbackMaterial { get; set; }
        public Material fallbackSourceMaterial { get; set; }
        public bool isDefaultMaterial { get; set; }
        public float padding { get; set; }
        public Renderer renderer { get; }
        public MeshFilter meshFilter { get; }
        public Mesh mesh { get; set; }
        public TMP_Text textComponent { get; }

        public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference);
        public void DestroySelf();
        public float GetPaddingForMaterial();
        public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold);
        public void SetVerticesDirty();
        public void SetMaterialDirty();
        protected void UpdateMaterial();
    }
}

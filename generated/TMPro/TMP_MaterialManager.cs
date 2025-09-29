#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
    public static class TMP_MaterialManager
    {
        public static Material GetStencilMaterial(Material baseMaterial, int stencilID);
        public static void ReleaseStencilMaterial(Material stencilMaterial);
        public static Material GetBaseMaterial(Material stencilMaterial);
        public static Material SetStencil(Material material, int stencilID);
        public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID);
        public static void RemoveStencilMaterial(Material stencilMaterial);
        public static void ReleaseBaseMaterial(Material baseMaterial);
        public static void ClearMaterials();
        public static int GetStencilID(GameObject obj);
        public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial);
        public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial);
        public static void AddFallbackMaterialReference(Material targetMaterial);
        public static void RemoveFallbackMaterialReference(Material targetMaterial);
        public static void CleanupFallbackMaterials();
        public static void ReleaseFallbackMaterial(Material fallbackMaterial);
        public static void CopyMaterialPresetProperties(Material source, Material destination);
    }
}

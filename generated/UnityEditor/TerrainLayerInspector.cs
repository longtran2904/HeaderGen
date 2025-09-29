#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(TerrainLayer))]
    public sealed class TerrainLayerInspector : Editor
    {
        public TerrainLayerInspector();

        public void ApplyCustomUI(ITerrainLayerCustomUI customUI, Terrain terrain);
        public override void OnInspectorGUI();
        public override bool HasPreviewGUI();
        public override void OnPreviewGUI(Rect r, GUIStyle background);
        public override Texture2D RenderStaticPreview(string assetPath, UnityEngine.Object[] subAssets, int width, int height);
    }
}

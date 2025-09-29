#region UnityEditor.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.TextCoreTextEngineModule.dll
#endregion

using UnityEngine.TextCore.Text;

namespace UnityEditor.TextCore.Text
{
    [CustomEditor(typeof(FontAsset))]
    public class FontAssetEditor : Editor
    {
        public FontAssetEditor();

        public void OnEnable();
        public void OnDisable();
        public override void OnInspectorGUI();
    }
}

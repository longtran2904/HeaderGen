#region UnityEditor.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.TextCoreTextEngineModule.dll
#endregion

using UnityEngine.TextCore.Text;

namespace UnityEditor.TextCore.Text
{
    [CustomEditor(typeof(SpriteAsset))]
    public class TextSpriteAssetEditor : Editor
    {
        public TextSpriteAssetEditor();

        public void OnEnable();
        public override void OnInspectorGUI();
    }
}

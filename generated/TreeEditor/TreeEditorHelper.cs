#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace TreeEditor
{
    public class TreeEditorHelper
    {

        public TreeEditorHelper();

        public void OnEnable(TreeData treeData);
        public bool AreShadersCorrect();
        public static string GetOptimizedShaderName(Shader shader);
        public static bool IsTreeLeafShader(Shader shader);
        public static bool IsTreeBarkShader(Shader shader);
        public bool GUITooManyShaders();
        public bool GUIWrongShader(string uniqueID, Material value, NodeType nodeType);
        public void RefreshAllTreeShaders();
        public bool NodeHasWrongMaterial(TreeGroup group);
        public static GUIContent GetGUIContent(string id);
        public static string ExtractLabel(string uiString);
        public static string ExtractTooltip(string uiString);
        public enum NodeType
        {

            BarkNode = 0,
            LeafNode = 1
        }
    }
}

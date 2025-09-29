#region Unity.TextMeshPro.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.Editor.dll
#endregion

using UnityEditor;
using UnityEngine;

namespace TMPro.EditorUtilities
{
    public abstract class TMP_BaseShaderGUI : ShaderGUI
    {
        protected MaterialEditor m_Editor;
        protected Material m_Material;
        protected MaterialProperty[] m_Properties;
        protected static bool s_DebugExtended;
        protected static GUIContent[] s_XywhVectorLabels;
        protected static GUIContent[] s_LbrtVectorLabels;
        protected static GUIContent[] s_CullingTypeLabels;

        protected TMP_BaseShaderGUI();

        public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties);
        protected abstract void DoGUI();
        protected bool BeginPanel(string panel, bool expanded);
        protected bool BeginPanel(string panel, ShaderFeature feature, bool expanded, bool readState = True);
        public void EndPanel();
        protected void DoPopup(string name, string label, GUIContent[] options);
        protected void DoCubeMap(string name, string label);
        protected void DoTexture2D(string name, string label, bool withTilingOffset = False, string[] speedNames = null);
        protected void DoUVSpeed(Rect rect, string[] names);
        protected void DoToggle(string name, string label);
        protected void DoFloat(string name, string label);
        protected void DoColor(string name, string label);
        protected void DoSlider(string name, string label);
        protected void DoSlider(string propertyName, string propertyField, string label);
        protected void DoVector2(string name, string label);
        protected void DoVector3(string name, string label);
        protected void DoVector(string name, string label, GUIContent[] subLabels);

        protected class ShaderFeature
        {
            public string undoLabel;
            public GUIContent label;
            public GUIContent[] keywordLabels;
            public string[] keywords;

            public ShaderFeature();

            public bool Active { get; }
            public int State { get; }

            public void ReadState(Material material);
            public void SetActive(bool active, Material material);
            public void DoPopup(MaterialEditor editor, Material material);
        }
    }
}

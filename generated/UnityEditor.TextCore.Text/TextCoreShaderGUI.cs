#region UnityEditor.TextCoreTextEngineModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.TextCoreTextEngineModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.TextCore.Text
{
    public abstract class TextCoreShaderGUI : ShaderGUI
    {
        protected MaterialEditor m_Editor;
        protected Material m_Material;
        protected MaterialProperty[] m_Properties;
        protected static bool s_DebugExtended;
        protected static GUIContent[] s_XywhVectorLabels;
        protected static GUIContent[] s_LbrtVectorLabels;
        protected static GUIContent[] s_CullingTypeLabels;

        protected TextCoreShaderGUI();

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

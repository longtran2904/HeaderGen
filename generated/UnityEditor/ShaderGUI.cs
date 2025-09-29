#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public abstract class ShaderGUI
    {

        protected ShaderGUI();

        public virtual void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties);
        public virtual void OnMaterialPreviewGUI(MaterialEditor materialEditor, Rect r, GUIStyle background);
        public virtual void OnMaterialInteractivePreviewGUI(MaterialEditor materialEditor, Rect r, GUIStyle background);
        public virtual void OnMaterialPreviewSettingsGUI(MaterialEditor materialEditor);
        public virtual void OnClosed(Material material);
        public virtual void AssignNewShaderToMaterial(Material material, Shader oldShader, Shader newShader);
        public virtual void ValidateMaterial(Material material);
        protected static MaterialProperty FindProperty(string propertyName, MaterialProperty[] properties);
        protected static MaterialProperty FindProperty(string propertyName, MaterialProperty[] properties, bool propertyIsMandatory);
    }
}

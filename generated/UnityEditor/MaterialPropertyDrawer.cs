#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public abstract class MaterialPropertyDrawer
    {
        protected MaterialPropertyDrawer();

        public virtual void OnGUI(Rect position, MaterialProperty prop, GUIContent label, MaterialEditor editor);
        public virtual void OnGUI(Rect position, MaterialProperty prop, string label, MaterialEditor editor);
        public virtual float GetPropertyHeight(MaterialProperty prop, string label, MaterialEditor editor);
        public virtual void Apply(MaterialProperty prop);
    }
}

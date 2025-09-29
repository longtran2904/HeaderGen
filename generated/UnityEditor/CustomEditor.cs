#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public class CustomEditor : Attribute
    {
        public CustomEditor(Type inspectedType);
        public CustomEditor(Type inspectedType, bool editorForChildClasses);

        public bool isFallback { get; set; }
    }
}

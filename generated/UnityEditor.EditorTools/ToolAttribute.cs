#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.EditorTools
{
    public abstract class ToolAttribute : Attribute
    {
        protected ToolAttribute(string displayName, Type targetType = null, Type editorToolContext = null);

        public string displayName { get; }
        public Type targetType { get; }
        public Type targetContext { get; }
    }
}

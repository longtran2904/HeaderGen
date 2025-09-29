#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.EditorTools
{
    [AttributeUsage(AttributeTargets.Class, Inherited = False)]
    public sealed class EditorToolAttribute : ToolAttribute
    {

        public EditorToolAttribute(string displayName, Type componentToolTarget = null);
        public EditorToolAttribute(string displayName, Type componentToolTarget, Type editorToolContext);
    }
}

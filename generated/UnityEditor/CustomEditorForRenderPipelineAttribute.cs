#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomEditorForRenderPipelineAttribute : CustomEditor
    {

        public CustomEditorForRenderPipelineAttribute(Type inspectedType, Type renderPipeline);
        public CustomEditorForRenderPipelineAttribute(Type inspectedType, Type renderPipeline, bool editorForChildClasses);
    }
}

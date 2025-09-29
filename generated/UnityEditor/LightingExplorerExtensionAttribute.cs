#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.Rendering;

namespace UnityEditor
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LightingExplorerExtensionAttribute : ScriptableRenderPipelineExtensionAttribute
    {
        public LightingExplorerExtensionAttribute(Type renderPipeline);
    }
}

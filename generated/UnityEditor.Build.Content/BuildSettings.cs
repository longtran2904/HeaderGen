#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.Build.Player;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Content
{
    [UsedByNativeCode]
    public struct BuildSettings
    {
        public TypeDB typeDB { get; set; }
        public BuildTarget target { get; set; }
        public BuildTargetGroup group { get; set; }
        public ContentBuildFlags buildFlags { get; set; }
    }
}

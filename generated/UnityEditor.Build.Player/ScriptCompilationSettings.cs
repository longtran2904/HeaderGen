#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEditor.Build.Player
{
    [UsedByNativeCode]
    public struct ScriptCompilationSettings
    {
        public int subtarget { get; set; }
        public BuildTarget target { get; set; }
        public BuildTargetGroup group { get; set; }
        public ScriptCompilationOptions options { get; set; }
        public string[] extraScriptingDefines { get; set; }
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.ObjectModel;
using UnityEngine.Scripting;

namespace UnityEditor.Build.Player
{
    [UsedByNativeCode]
    public struct ScriptCompilationResult
    {

        public ReadOnlyCollection<string> assemblies { get; }
        public TypeDB typeDB { get; }
    }
}

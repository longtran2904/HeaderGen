#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Player
{
    [NativeHeader("Modules/BuildPipeline/Editor/Public/PlayerBuildInterface.h")]
    public static class PlayerBuildInterface
    {
        public static Func<IEnumerable<string>> ExtraTypesProvider;

        public static ScriptCompilationResult CompilePlayerScripts(ScriptCompilationSettings input, string outputFolder);
    }
}

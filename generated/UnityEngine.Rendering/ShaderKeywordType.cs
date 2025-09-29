#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
    [UsedByNativeCode]
    public enum ShaderKeywordType
    {

        None = 0,
        BuiltinDefault = 2,
        [Obsolete("Shader keyword type BuiltinExtra is no longer used. Use BuiltinDefault instead. (UnityUpgradable) -> BuiltinDefault")]
        BuiltinExtra = 6,
        [Obsolete("Shader keyword type BuiltinAutoStripped is no longer used. Use BuiltinDefault instead. (UnityUpgradable) -> BuiltinDefault")]
        BuiltinAutoStripped = 10,
        UserDefined = 16,
        Plugin = 32
    }
}

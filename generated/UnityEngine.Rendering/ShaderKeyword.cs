#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
    [NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
    [UsedByNativeCode]
    public struct ShaderKeyword
    {
        public ShaderKeyword(string keywordName);
        public ShaderKeyword(Shader shader, string keywordName);
        public ShaderKeyword(ComputeShader shader, string keywordName);

        public string name { get; }
        public int index { get; }

        public static ShaderKeywordType GetGlobalKeywordType(ShaderKeyword index);
        public static bool IsKeywordLocal(ShaderKeyword keyword);
        public bool IsValid();
        public bool IsValid(ComputeShader shader);
        public bool IsValid(Shader shader);
        public override string ToString();
        [Obsolete("GetKeywordType is deprecated. Only global keywords can have a type. This method always returns ShaderKeywordType.UserDefined.")]
        public static ShaderKeywordType GetKeywordType(Shader shader, ShaderKeyword index);
        [Obsolete("GetKeywordType is deprecated. Only global keywords can have a type. This method always returns ShaderKeywordType.UserDefined.")]
        public static ShaderKeywordType GetKeywordType(ComputeShader shader, ShaderKeyword index);
        [Obsolete("GetGlobalKeywordName is deprecated. Use the ShaderKeyword.name property instead.")]
        public static string GetGlobalKeywordName(ShaderKeyword index);
        [Obsolete("GetKeywordName is deprecated. Use the ShaderKeyword.name property instead.")]
        public static string GetKeywordName(Shader shader, ShaderKeyword index);
        [Obsolete("GetKeywordName is deprecated. Use the ShaderKeyword.name property instead.")]
        public static string GetKeywordName(ComputeShader shader, ShaderKeyword index);
        [Obsolete("GetKeywordType is deprecated. Use ShaderKeyword.name instead.")]
        public ShaderKeywordType GetKeywordType();
        [Obsolete("GetKeywordName is deprecated. Use ShaderKeyword.name instead.")]
        public string GetKeywordName();
        [Obsolete("GetName() has been deprecated. Use ShaderKeyword.name instead.")]
        public string GetName();
    }
}

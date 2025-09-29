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
    public readonly struct LocalKeyword : IEquatable<LocalKeyword>
    {

        public LocalKeyword(Shader shader, string name);
        public LocalKeyword(ComputeShader shader, string name);

        public string name { get; }
        public bool isOverridable { get; }
        public bool isValid { get; }
        public ShaderKeywordType type { get; }

        public override string ToString();
        public override bool Equals(object o);
        public bool Equals(LocalKeyword rhs);
        public override int GetHashCode();

        public static bool operator ==(LocalKeyword lhs, LocalKeyword rhs);
        public static bool operator !=(LocalKeyword lhs, LocalKeyword rhs);
    }
}

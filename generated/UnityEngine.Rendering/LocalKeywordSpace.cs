#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
    public readonly struct LocalKeywordSpace : IEquatable<LocalKeywordSpace>
    {
        public LocalKeyword[] keywords { get; }
        public string[] keywordNames { get; }
        public uint keywordCount { get; }

        public LocalKeyword FindKeyword(string name);
        public override bool Equals(object o);
        public bool Equals(LocalKeywordSpace rhs);
        public override int GetHashCode();

        public static bool operator ==(LocalKeywordSpace lhs, LocalKeywordSpace rhs);
        public static bool operator !=(LocalKeywordSpace lhs, LocalKeywordSpace rhs);
    }
}

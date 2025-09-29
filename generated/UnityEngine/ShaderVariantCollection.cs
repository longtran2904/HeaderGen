#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
    public sealed class ShaderVariantCollection : Object
    {

        public ShaderVariantCollection();

        public int shaderCount { get; }
        public int variantCount { get; }
        public bool isWarmedUp { get; }

        [NativeName("ClearVariants")]
        public void Clear();
        [NativeName("WarmupShaders")]
        public void WarmUp();
        public bool Add(ShaderVariant variant);
        public bool Remove(ShaderVariant variant);
        public bool Contains(ShaderVariant variant);
        public struct ShaderVariant
        {

            public Shader shader;
            public PassType passType;
            public string[] keywords;

            public ShaderVariant(Shader shader, PassType passType, params string[] keywords);
        }
    }
}

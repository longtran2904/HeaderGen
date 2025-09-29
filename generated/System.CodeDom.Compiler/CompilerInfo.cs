#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections.Generic;

namespace System.CodeDom.Compiler
{
    public sealed class CompilerInfo
    {
        public Type CodeDomProviderType { get; }
        public bool IsCodeDomProviderTypeValid { get; }

        public string[] GetLanguages();
        public string[] GetExtensions();
        public CodeDomProvider CreateProvider();
        public CodeDomProvider CreateProvider(IDictionary<string, string> providerOptions);
        public CompilerParameters CreateDefaultCompilerParameters();
        public override int GetHashCode();
        public override bool Equals(object o);
    }
}

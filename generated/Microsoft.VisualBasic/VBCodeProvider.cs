#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Microsoft.VisualBasic
{
    public class VBCodeProvider : CodeDomProvider
    {

        public VBCodeProvider();
        public VBCodeProvider(IDictionary<string, string> providerOptions);

        public override string FileExtension { get; }
        public override LanguageOptions LanguageOptions { get; }

        [Obsolete("ICodeGenerator has been deprecated. Use the methods directly on the CodeDomProvider class instead.")]
        public override ICodeGenerator CreateGenerator();
        [Obsolete("ICodeCompiler has been deprecated. Use the methods directly on the CodeDomProvider class instead.")]
        public override ICodeCompiler CreateCompiler();
        public override TypeConverter GetConverter(Type type);
        public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options);
    }
}

#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Reflection;

namespace System.CodeDom.Compiler
{
    [DefaultMember("Item")]
    public class CodeGeneratorOptions
    {
        public CodeGeneratorOptions();

        public object this[string index] { get; set; }
        public string IndentString { get; set; }
        public string BracingStyle { get; set; }
        public bool ElseOnClosing { get; set; }
        public bool BlankLinesBetweenMembers { get; set; }
        public bool VerbatimOrder { get; set; }
    }
}

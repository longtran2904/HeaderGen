#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.IO;

namespace System.CodeDom.Compiler
{
    public abstract class CodeParser : ICodeParser
    {
        protected CodeParser();

        public abstract CodeCompileUnit Parse(TextReader codeStream);
    }
}

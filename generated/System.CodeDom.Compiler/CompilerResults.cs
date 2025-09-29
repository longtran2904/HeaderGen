#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections.Specialized;
using System.Reflection;

namespace System.CodeDom.Compiler
{
    public class CompilerResults
    {

        public CompilerResults(TempFileCollection tempFiles);

        public TempFileCollection TempFiles { get; set; }
        public Assembly CompiledAssembly { get; set; }
        public CompilerErrorCollection Errors { get; }
        public StringCollection Output { get; }
        public string PathToAssembly { get; set; }
        public int NativeCompilerReturnValue { get; set; }
    }
}

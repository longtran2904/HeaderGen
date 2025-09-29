#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom.Compiler
{
    public class CompilerError
    {

        public CompilerError();
        public CompilerError(string fileName, int line, int column, string errorNumber, string errorText);

        public int Line { get; set; }
        public int Column { get; set; }
        public string ErrorNumber { get; set; }
        public string ErrorText { get; set; }
        public bool IsWarning { get; set; }
        public string FileName { get; set; }

        public override string ToString();
    }
}

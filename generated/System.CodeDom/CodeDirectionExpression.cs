#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeDirectionExpression : CodeExpression
    {
        public CodeDirectionExpression();
        public CodeDirectionExpression(FieldDirection direction, CodeExpression expression);

        public CodeExpression Expression { get; set; }
        public FieldDirection Direction { get; set; }
    }
}

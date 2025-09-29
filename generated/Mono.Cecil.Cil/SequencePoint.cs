#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil.Cil
{
    public sealed class SequencePoint
    {

        public SequencePoint(Instruction instruction, Document document);

        public int Offset { get; }
        public int StartLine { get; set; }
        public int StartColumn { get; set; }
        public int EndLine { get; set; }
        public int EndColumn { get; set; }
        public bool IsHidden { get; }
        public Document Document { get; set; }
    }
}

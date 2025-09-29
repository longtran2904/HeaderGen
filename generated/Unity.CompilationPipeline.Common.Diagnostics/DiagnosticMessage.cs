#region Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.CompilationPipeline.Common.dll
#endregion

namespace Unity.CompilationPipeline.Common.Diagnostics
{
    public class DiagnosticMessage
    {
        public DiagnosticMessage();

        public string File { get; set; }
        public DiagnosticType DiagnosticType { get; set; }
        public string MessageData { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
    }
}

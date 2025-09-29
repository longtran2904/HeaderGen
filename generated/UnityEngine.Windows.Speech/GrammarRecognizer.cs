#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Windows.Speech
{
    public sealed class GrammarRecognizer : PhraseRecognizer
    {

        public GrammarRecognizer(string grammarFilePath);
        public GrammarRecognizer(string grammarFilePath, ConfidenceLevel minimumConfidence);

        public string GrammarFilePath { get; }
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Windows.Speech
{
    public struct PhraseRecognizedEventArgs
    {
        public readonly ConfidenceLevel confidence;
        public readonly SemanticMeaning[] semanticMeanings;
        public readonly string text;
        public readonly DateTime phraseStartTime;
        public readonly TimeSpan phraseDuration;
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Windows.Speech
{
    public sealed class KeywordRecognizer : PhraseRecognizer
    {

        public KeywordRecognizer(string[] keywords);
        public KeywordRecognizer(string[] keywords, ConfidenceLevel minimumConfidence);

        public IEnumerable<string> Keywords { get; }
    }
}

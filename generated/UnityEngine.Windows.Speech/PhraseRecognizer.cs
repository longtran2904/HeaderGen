#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Windows.Speech
{
    public abstract class PhraseRecognizer : IDisposable
    {

        protected nint m_Recognizer;

        ~PhraseRecognizer();

        public bool IsRunning { get; }

        public event PhraseRecognizedDelegate OnPhraseRecognized;

        [NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
        [NativeThrows]
        protected static nint CreateFromKeywords(object self, [Unmarshalled] string[] keywords, ConfidenceLevel minimumConfidence);
        [NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
        [NativeThrows]
        protected static nint CreateFromGrammarFile(object self, string grammarFilePath, ConfidenceLevel minimumConfidence);
        public void Start();
        public void Stop();
        public void Dispose();
        public delegate void PhraseRecognizedDelegate(PhraseRecognizedEventArgs args);
    }
}

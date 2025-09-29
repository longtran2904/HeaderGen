#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Windows.Speech
{
    public sealed class DictationRecognizer : IDisposable
    {

        public DictationRecognizer();
        public DictationRecognizer(ConfidenceLevel confidenceLevel);
        public DictationRecognizer(DictationTopicConstraint topic);
        public DictationRecognizer(ConfidenceLevel minimumConfidence, DictationTopicConstraint topic);

        ~DictationRecognizer();

        public SpeechSystemStatus Status { get; }
        public float AutoSilenceTimeoutSeconds { get; set; }
        public float InitialSilenceTimeoutSeconds { get; set; }

        public event DictationHypothesisDelegate DictationHypothesis;
        public event DictationResultDelegate DictationResult;
        public event DictationCompletedDelegate DictationComplete;
        public event DictationErrorHandler DictationError;

        public void Start();
        public void Stop();
        public void Dispose();
        public delegate void DictationHypothesisDelegate(string text);
        public delegate void DictationResultDelegate(string text, ConfidenceLevel confidence);
        public delegate void DictationCompletedDelegate(DictationCompletionCause cause);
        public delegate void DictationErrorHandler(string error, int hresult);
    }
}

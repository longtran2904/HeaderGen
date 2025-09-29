#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Windows.Speech
{
    public static class PhraseRecognitionSystem
    {

        public static bool isSupported { get; }
        public static SpeechSystemStatus Status { get; }

        public static event ErrorDelegate OnError;
        public static event StatusDelegate OnStatusChanged;

        [NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
        [NativeThrows]
        public static void Restart();
        [NativeHeader("PlatformDependent/Win/Bindings/SpeechBindings.h")]
        public static void Shutdown();
        public delegate void ErrorDelegate(SpeechError errorCode);
        public delegate void StatusDelegate(SpeechSystemStatus status);
    }
}

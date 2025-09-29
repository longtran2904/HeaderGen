#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
    public sealed class Microphone
    {
        public Microphone();

        public static string[] devices { get; }

        public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency);
        public static void End(string deviceName);
        public static bool IsRecording(string deviceName);
        public static int GetPosition(string deviceName);
        public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq);
    }
}

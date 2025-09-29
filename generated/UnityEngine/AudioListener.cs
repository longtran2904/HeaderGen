#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [RequireComponent(typeof(Transform))]
    [StaticAccessor("AudioListenerBindings", StaticAccessorType.DoubleColon)]
    public sealed class AudioListener : AudioBehaviour
    {
        public AudioListener();

        public static float volume { get; set; }
        [NativeProperty("ListenerPause")]
        public static bool pause { get; set; }
        public AudioVelocityUpdateMode velocityUpdateMode { get; set; }

        [Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
        public static float[] GetOutputData(int numSamples, int channel);
        public static void GetOutputData(float[] samples, int channel);
        [Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
        public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window);
        public static void GetSpectrumData(float[] samples, int channel, FFTWindow window);
    }
}

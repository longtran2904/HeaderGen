#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
    [StaticAccessor("AudioClipBindings", StaticAccessorType.DoubleColon)]
    public sealed class AudioClip : Object
    {
        [NativeProperty("LengthSec")]
        public float length { get; }
        [NativeProperty("SampleCount")]
        public int samples { get; }
        [NativeProperty("ChannelCount")]
        public int channels { get; }
        public int frequency { get; }
        [Obsolete("Use AudioClip.loadState instead to get more detailed information about the loading process.")]
        public bool isReadyToPlay { get; }
        public AudioClipLoadType loadType { get; }
        public bool preloadAudioData { get; }
        public bool ambisonic { get; }
        public bool loadInBackground { get; }
        public AudioDataLoadState loadState { get; }

        public bool LoadAudioData();
        public bool UnloadAudioData();
        public bool GetData(float[] data, int offsetSamples);
        public bool SetData(float[] data, int offsetSamples);
        [Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
        public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream);
        [Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
        public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback);
        [Obsolete("The _3D argument of AudioClip is deprecated. Use the spatialBlend property of AudioSource instead to morph between 2D and 3D playback.")]
        public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback);
        public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream);
        public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback);
        public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback);

        public delegate void PCMReaderCallback(float[] data);
        public delegate void PCMSetPositionCallback(int position);
    }
}

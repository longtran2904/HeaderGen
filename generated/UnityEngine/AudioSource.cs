#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [RequireComponent(typeof(Transform))]
    [StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
    public sealed class AudioSource : AudioBehaviour
    {

        public AudioSource();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("AudioSource.panLevel has been deprecated. Use AudioSource.spatialBlend instead (UnityUpgradable) -> spatialBlend", True)]
        public float panLevel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("AudioSource.pan has been deprecated. Use AudioSource.panStereo instead (UnityUpgradable) -> panStereo", True)]
        public float pan { get; set; }
        public float volume { get; set; }
        public float pitch { get; set; }
        [NativeProperty("SecPosition")]
        public float time { get; set; }
        [NativeProperty("SamplePosition")]
        public int timeSamples { get; set; }
        [NativeProperty("AudioClip")]
        public AudioClip clip { get; set; }
        public AudioMixerGroup outputAudioMixerGroup { get; set; }
        [NativeConditional("PLATFORM_SUPPORTS_GAMEPAD_AUDIO")]
        public GamepadSpeakerOutputType gamepadSpeakerOutputType { get; set; }
        public bool isPlaying { get; }
        public bool isVirtual { get; }
        public bool loop { get; set; }
        public bool ignoreListenerVolume { get; set; }
        public bool playOnAwake { get; set; }
        public bool ignoreListenerPause { get; set; }
        public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
        [NativeProperty("StereoPan")]
        public float panStereo { get; set; }
        [NativeProperty("SpatialBlendMix")]
        public float spatialBlend { get; set; }
        public bool spatialize { get; set; }
        public bool spatializePostEffects { get; set; }
        public float reverbZoneMix { get; set; }
        public bool bypassEffects { get; set; }
        public bool bypassListenerEffects { get; set; }
        public bool bypassReverbZones { get; set; }
        public float dopplerLevel { get; set; }
        public float spread { get; set; }
        public int priority { get; set; }
        public bool mute { get; set; }
        public float minDistance { get; set; }
        public float maxDistance { get; set; }
        public AudioRolloffMode rolloffMode { get; set; }
        [Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
        public float minVolume { get; set; }
        [Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
        public float maxVolume { get; set; }
        [Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
        public float rolloffFactor { get; set; }

        [NativeConditional("PLATFORM_SUPPORTS_GAMEPAD_AUDIO")]
        [NativeMethod(Name = "AudioSourceBindings::PlayOnGamepad", ThrowsException = True, HasExplicitThis = True)]
        public bool PlayOnGamepad(int slot);
        [NativeConditional("PLATFORM_SUPPORTS_GAMEPAD_AUDIO")]
        [NativeMethod(Name = "AudioSourceBindings::DisableGamepadOutput", HasExplicitThis = True)]
        public bool DisableGamepadOutput();
        [NativeConditional("PLATFORM_SUPPORTS_GAMEPAD_AUDIO")]
        [NativeMethod(Name = "AudioSourceBindings::SetGamepadSpeakerMixLevel", ThrowsException = True, HasExplicitThis = True)]
        public bool SetGamepadSpeakerMixLevel(int slot, int mixLevel);
        [NativeConditional("PLATFORM_SUPPORTS_GAMEPAD_AUDIO")]
        [NativeMethod(Name = "AudioSourceBindings::SetGamepadSpeakerMixLevelDefault", ThrowsException = True, HasExplicitThis = True)]
        public bool SetGamepadSpeakerMixLevelDefault(int slot);
        [NativeConditional("PLATFORM_SUPPORTS_GAMEPAD_AUDIO")]
        [NativeMethod(Name = "AudioSourceBindings::SetGamepadSpeakerRestrictedAudio", ThrowsException = True, HasExplicitThis = True)]
        public bool SetGamepadSpeakerRestrictedAudio(int slot, bool restricted);
        [NativeConditional("PLATFORM_SUPPORTS_GAMEPAD_AUDIO")]
        [NativeMethod(Name = "GamepadSpeakerSupportsOutputType", HasExplicitThis = False)]
        public static bool GamepadSpeakerSupportsOutputType(GamepadSpeakerOutputType outputType);
        [ExcludeFromDocs]
        public void Play();
        public void Play([DefaultValue("0")] ulong delay);
        public void PlayDelayed(float delay);
        public void PlayScheduled(double time);
        [ExcludeFromDocs]
        public void PlayOneShot(AudioClip clip);
        public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale);
        public void SetScheduledStartTime(double time);
        public void SetScheduledEndTime(double time);
        public void Stop();
        public void Pause();
        public void UnPause();
        [ExcludeFromDocs]
        public static void PlayClipAtPoint(AudioClip clip, Vector3 position);
        public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume);
        public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve);
        public AnimationCurve GetCustomCurve(AudioSourceCurveType type);
        [Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
        public float[] GetOutputData(int numSamples, int channel);
        public void GetOutputData(float[] samples, int channel);
        [Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
        public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window);
        public void GetSpectrumData(float[] samples, int channel, FFTWindow window);
        public bool SetSpatializerFloat(int index, float value);
        public bool GetSpatializerFloat(int index, out float value);
        public bool GetAmbisonicDecoderFloat(int index, out float value);
        public bool SetAmbisonicDecoderFloat(int index, float value);
    }
}

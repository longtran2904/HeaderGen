#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
    [StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
    public sealed class AudioSettings
    {
        public AudioSettings();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("AudioSettings.driverCaps is obsolete. Use driverCapabilities instead (UnityUpgradable) -> driverCapabilities", True)]
        public static AudioSpeakerMode driverCaps { get; }
        public static AudioSpeakerMode driverCapabilities { get; }
        public static AudioSpeakerMode speakerMode { get; set; }
        public static double dspTime { get; }
        public static int outputSampleRate { get; set; }

        public static event AudioConfigurationChangeHandler OnAudioConfigurationChanged;

        [NativeMethod(Name = "AudioSettings::GetDSPBufferSize", IsFreeFunction = True)]
        public static void GetDSPBufferSize(out int bufferLength, out int numBuffers);
        [Obsolete("AudioSettings.SetDSPBufferSize is deprecated and has been replaced by audio project settings and the AudioSettings.GetConfiguration/AudioSettings.Reset API.")]
        public static void SetDSPBufferSize(int bufferLength, int numBuffers);
        [NativeMethod(Name = "AudioSettings::GetSpatializerNames", IsFreeFunction = True)]
        public static string[] GetSpatializerPluginNames();
        [NativeName("GetCurrentSpatializerDefinitionName")]
        public static string GetSpatializerPluginName();
        public static void SetSpatializerPluginName(string pluginName);
        public static AudioConfiguration GetConfiguration();
        public static bool Reset(AudioConfiguration config);

        public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);
        public static class Mobile
        {
            public static bool muteState { get; }
            public static bool stopAudioOutputOnMute { get; set; }
            public static bool audioOutputStarted { get; }

            public static event Action<bool> OnMuteStateChanged;

            public static void StartAudioOutput();
            public static void StopAudioOutput();
        }
    }
}

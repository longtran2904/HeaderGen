#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Audio
{
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    [NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
    [NativeHeader("Modules/Audio/Public/AudioMixer.h")]
    public class AudioMixer : Object
    {

        [NativeProperty]
        public AudioMixerGroup outputAudioMixerGroup { get; set; }
        [NativeProperty]
        public AudioMixerUpdateMode updateMode { get; set; }

        [NativeMethod("FindSnapshotFromName")]
        public AudioMixerSnapshot FindSnapshot(string name);
        [NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = True, HasExplicitThis = True)]
        public AudioMixerGroup[] FindMatchingGroups(string subPath);
        [NativeMethod("AudioMixerBindings::TransitionToSnapshots", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
        public void TransitionToSnapshots(AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach);
        [NativeMethod]
        public bool SetFloat(string name, float value);
        [NativeMethod]
        public bool ClearFloat(string name);
        [NativeMethod]
        public bool GetFloat(string name, out float value);
    }
}

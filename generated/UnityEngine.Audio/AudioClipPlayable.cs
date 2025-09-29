#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
    [NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
    [NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct AudioClipPlayable : IEquatable<AudioClipPlayable>, IPlayable
    {

        public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping);
        public PlayableHandle GetHandle();
        public bool Equals(AudioClipPlayable other);
        public AudioClip GetClip();
        public void SetClip(AudioClip value);
        public bool GetLooped();
        public void SetLooped(bool value);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("IsPlaying() has been deprecated. Use IsChannelPlaying() instead (UnityUpgradable) -> IsChannelPlaying()", True)]
        public bool IsPlaying();
        public bool IsChannelPlaying();
        public double GetStartDelay();
        public double GetPauseDelay();
        public void Seek(double startTime, double startDelay);
        public void Seek(double startTime, double startDelay, [DefaultValue("0")] double duration);

        public static implicit operator Playable(AudioClipPlayable playable);
        public static explicit operator AudioClipPlayable(Playable playable);
    }
}

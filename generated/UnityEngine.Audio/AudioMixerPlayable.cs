#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
    [NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable>, IPlayable
    {
        public static AudioMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeInputVolumes = False);
        public PlayableHandle GetHandle();
        public bool Equals(AudioMixerPlayable other);

        public static implicit operator Playable(AudioMixerPlayable playable);
        public static explicit operator AudioMixerPlayable(Playable playable);
    }
}

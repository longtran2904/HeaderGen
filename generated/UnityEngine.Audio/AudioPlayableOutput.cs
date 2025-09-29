#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio
{
    [NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
    [NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
    [NativeHeader("Modules/Audio/Public/AudioSource.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
    public struct AudioPlayableOutput : IPlayableOutput
    {

        public static AudioPlayableOutput Null { get; }

        public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target);
        public PlayableOutputHandle GetHandle();
        public AudioSource GetTarget();
        public void SetTarget(AudioSource value);
        public bool GetEvaluateOnSeek();
        public void SetEvaluateOnSeek(bool value);

        public static implicit operator PlayableOutput(AudioPlayableOutput output);
        public static explicit operator AudioPlayableOutput(PlayableOutput output);
    }
}

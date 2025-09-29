#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine.Audio
{
    [NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
    public class AudioMixerSnapshot : Object, ISubAssetNotDuplicatable
    {
        [NativeProperty]
        public AudioMixer audioMixer { get; }

        public void TransitionTo(float timeToReach);
    }
}

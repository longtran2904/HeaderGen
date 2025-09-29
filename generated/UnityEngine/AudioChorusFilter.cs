#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;

namespace UnityEngine
{
    [RequireComponent(typeof(AudioBehaviour))]
    public sealed class AudioChorusFilter : Behaviour
    {
        public AudioChorusFilter();

        public float dryMix { get; set; }
        public float wetMix1 { get; set; }
        public float wetMix2 { get; set; }
        public float wetMix3 { get; set; }
        public float delay { get; set; }
        public float rate { get; set; }
        public float depth { get; set; }
        [Obsolete("Warning! Feedback is deprecated. This property does nothing.")]
        public float feedback { get; set; }
    }
}

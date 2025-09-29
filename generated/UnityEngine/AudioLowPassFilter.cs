#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [RequireComponent(typeof(AudioBehaviour))]
    public sealed class AudioLowPassFilter : Behaviour
    {

        public AudioLowPassFilter();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("AudioLowPassFilter.lowpassResonaceQ is obsolete. Use lowpassResonanceQ instead (UnityUpgradable) -> lowpassResonanceQ", True)]
        public float lowpassResonaceQ { get; set; }
        public AnimationCurve customCutoffCurve { get; set; }
        public float cutoffFrequency { get; set; }
        public float lowpassResonanceQ { get; set; }
    }
}

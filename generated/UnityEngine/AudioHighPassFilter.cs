#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [RequireComponent(typeof(AudioBehaviour))]
    public sealed class AudioHighPassFilter : Behaviour
    {

        public AudioHighPassFilter();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("AudioHighPassFilter.highpassResonaceQ is obsolete. Use highpassResonanceQ instead (UnityUpgradable) -> highpassResonanceQ", True)]
        public float highpassResonaceQ { get; set; }
        public float cutoffFrequency { get; set; }
        public float highpassResonanceQ { get; set; }
    }
}

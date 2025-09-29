#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [RequireComponent(typeof(AudioBehaviour))]
    public sealed class AudioReverbFilter : Behaviour
    {

        public AudioReverbFilter();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("AudioReverbFilter.lFReference is obsolete. Use lfReference instead (UnityUpgradable) -> lfReference", True)]
        public float lFReference { get; set; }
        public AudioReverbPreset reverbPreset { get; set; }
        public float dryLevel { get; set; }
        public float room { get; set; }
        public float roomHF { get; set; }
        [Obsolete("Warning! roomRolloffFactor is no longer supported.")]
        public float roomRolloffFactor { get; set; }
        public float decayTime { get; set; }
        public float decayHFRatio { get; set; }
        public float reflectionsLevel { get; set; }
        public float reflectionsDelay { get; set; }
        public float reverbLevel { get; set; }
        public float reverbDelay { get; set; }
        public float diffusion { get; set; }
        public float density { get; set; }
        public float hfReference { get; set; }
        public float roomLF { get; set; }
        public float lfReference { get; set; }
    }
}

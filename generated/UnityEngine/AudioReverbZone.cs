#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Audio/Public/AudioReverbZone.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class AudioReverbZone : Behaviour
    {

        public AudioReverbZone();

        public float minDistance { get; set; }
        public float maxDistance { get; set; }
        public AudioReverbPreset reverbPreset { get; set; }
        public int room { get; set; }
        public int roomHF { get; set; }
        public int roomLF { get; set; }
        public float decayTime { get; set; }
        public float decayHFRatio { get; set; }
        public int reflections { get; set; }
        public float reflectionsDelay { get; set; }
        public int reverb { get; set; }
        public float reverbDelay { get; set; }
        public float HFReference { get; set; }
        public float LFReference { get; set; }
        [Obsolete("Warning! roomRolloffFactor is no longer supported.")]
        public float roomRolloffFactor { get; set; }
        public float diffusion { get; set; }
        public float density { get; set; }
    }
}

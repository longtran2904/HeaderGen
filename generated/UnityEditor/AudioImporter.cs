#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Modules/AssetPipelineEditor/Public/AudioImporter.h")]
    public sealed class AudioImporter : AssetImporter
    {
        public AudioImporter();

        public AudioImporterSampleSettings defaultSampleSettings { get; set; }
        public bool forceToMono { get; set; }
        public bool ambisonic { get; set; }
        public bool loadInBackground { get; set; }
        public bool preloadAudioData { get; set; }
        [Obsolete("Setting and getting import channels is not used anymore (use forceToMono instead)", True)]
        public AudioImporterChannels channels { get; set; }
        [Obsolete("AudioImporter.compressionBitrate is no longer supported", True)]
        public int compressionBitrate { get; set; }
        [Obsolete("AudioImporter.loopable is no longer supported. All audio assets encoded by Unity are by default loopable.")]
        public bool loopable { get; set; }
        [Obsolete("AudioImporter.hardware is no longer supported. All mixing of audio is done by software and only some platforms use hardware acceleration to perform decoding.")]
        public bool hardware { get; set; }
        [Obsolete("AudioImporter.threeD is no longer supported")]
        public bool threeD { get; set; }

        public bool ContainsSampleSettingsOverride(string platform);
        public AudioImporterSampleSettings GetOverrideSampleSettings(string platform);
        public bool SetOverrideSampleSettings(string platform, AudioImporterSampleSettings settings);
        public bool ClearSampleSettingOverride(string platform);
    }
}

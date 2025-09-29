#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Audio
{
    [NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
    [StaticAccessor("AudioSampleProviderBindings", StaticAccessorType.DoubleColon)]
    public class AudioSampleProvider : IDisposable
    {
        ~AudioSampleProvider();

        public uint id { get; }
        public ushort trackIndex { get; }
        public Object owner { get; }
        public bool valid { get; }
        public ushort channelCount { get; }
        public uint sampleRate { get; }
        public uint maxSampleFrameCount { get; }
        public uint availableSampleFrameCount { get; }
        public uint freeSampleFrameCount { get; }
        public uint freeSampleFrameCountLowThreshold { get; set; }
        public bool enableSampleFramesAvailableEvents { get; set; }
        public bool enableSilencePadding { get; set; }
        public static ConsumeSampleFramesNativeFunction consumeSampleFramesNativeFunction { get; }

        public event SampleFramesHandler sampleFramesAvailable;
        public event SampleFramesHandler sampleFramesOverflow;

        public void Dispose();
        public uint ConsumeSampleFrames(NativeArray<float> sampleFrames);
        public void SetSampleFramesAvailableNativeHandler(SampleFramesEventNativeFunction handler, nint userData);
        public void ClearSampleFramesAvailableNativeHandler();
        public void SetSampleFramesOverflowNativeHandler(SampleFramesEventNativeFunction handler, nint userData);
        public void ClearSampleFramesOverflowNativeHandler();

        public delegate uint ConsumeSampleFramesNativeFunction(uint providerId, nint interleavedSampleFrames, uint sampleFrameCount);
        public delegate void SampleFramesHandler(AudioSampleProvider provider, uint sampleFrameCount);
        public delegate void SampleFramesEventNativeFunction(nint userData, uint providerId, uint sampleFrameCount);
    }
}

#region UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VideoModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
    [NativeHeader("Modules/Video/Public/VideoPlayer.h")]
    [RequireComponent(typeof(Transform))]
    [RequiredByNativeCode]
    public sealed class VideoPlayer : Behaviour
    {
        public VideoPlayer();

        public VideoSource source { get; set; }
        [NativeName("VideoUrl")]
        public string url { get; set; }
        [NativeName("VideoClip")]
        public VideoClip clip { get; set; }
        public VideoRenderMode renderMode { get; set; }
        [NativeHeader("Runtime/Camera/Camera.h")]
        public Camera targetCamera { get; set; }
        [NativeHeader("Runtime/Graphics/RenderTexture.h")]
        public RenderTexture targetTexture { get; set; }
        [NativeHeader("Runtime/Graphics/Renderer.h")]
        public Renderer targetMaterialRenderer { get; set; }
        public string targetMaterialProperty { get; set; }
        public VideoAspectRatio aspectRatio { get; set; }
        public float targetCameraAlpha { get; set; }
        public Video3DLayout targetCamera3DLayout { get; set; }
        [NativeHeader("Runtime/Graphics/Texture.h")]
        public Texture texture { get; }
        public bool isPrepared { get; }
        public bool waitForFirstFrame { get; set; }
        public bool playOnAwake { get; set; }
        public bool isPlaying { get; }
        public bool isPaused { get; }
        public bool canSetTime { get; }
        [NativeName("SecPosition")]
        public double time { get; set; }
        [NativeName("FramePosition")]
        public long frame { get; set; }
        public double clockTime { get; }
        public bool canStep { get; }
        public bool canSetPlaybackSpeed { get; }
        public float playbackSpeed { get; set; }
        [NativeName("Loop")]
        public bool isLooping { get; set; }
        public bool canSetTimeSource { get; }
        public VideoTimeSource timeSource { get; set; }
        public VideoTimeReference timeReference { get; set; }
        public double externalReferenceTime { get; set; }
        public bool canSetSkipOnDrop { get; }
        public bool skipOnDrop { get; set; }
        public ulong frameCount { get; }
        public float frameRate { get; }
        [NativeName("Duration")]
        public double length { get; }
        public uint width { get; }
        public uint height { get; }
        public uint pixelAspectRatioNumerator { get; }
        public uint pixelAspectRatioDenominator { get; }
        public ushort audioTrackCount { get; }
        public static ushort controlledAudioTrackMaxCount { get; }
        public ushort controlledAudioTrackCount { get; set; }
        public VideoAudioOutputMode audioOutputMode { get; set; }
        public bool canSetDirectAudioVolume { get; }
        public bool sendFrameReadyEvents { get; set; }

        public event EventHandler prepareCompleted;
        public event EventHandler loopPointReached;
        public event EventHandler started;
        public event EventHandler frameDropped;
        public event ErrorEventHandler errorReceived;
        public event EventHandler seekCompleted;
        public event TimeEventHandler clockResyncOccurred;
        public event FrameReadyEventHandler frameReady;

        public void Prepare();
        public void Play();
        public void Pause();
        public void Stop();
        public void StepForward();
        public string GetAudioLanguageCode(ushort trackIndex);
        public ushort GetAudioChannelCount(ushort trackIndex);
        public uint GetAudioSampleRate(ushort trackIndex);
        public void EnableAudioTrack(ushort trackIndex, bool enabled);
        public bool IsAudioTrackEnabled(ushort trackIndex);
        public float GetDirectAudioVolume(ushort trackIndex);
        public void SetDirectAudioVolume(ushort trackIndex, float volume);
        public bool GetDirectAudioMute(ushort trackIndex);
        public void SetDirectAudioMute(ushort trackIndex, bool mute);
        [NativeHeader("Modules/Audio/Public/AudioSource.h")]
        public AudioSource GetTargetAudioSource(ushort trackIndex);
        public void SetTargetAudioSource(ushort trackIndex, AudioSource source);

        public delegate void EventHandler(VideoPlayer source);
        public delegate void ErrorEventHandler(VideoPlayer source, string message);
        public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx);
        public delegate void TimeEventHandler(VideoPlayer source, double seconds);
    }
}

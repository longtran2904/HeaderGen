#region UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VideoModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Video;

namespace UnityEngine.Experimental.Video
{
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
    [NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
    [NativeHeader("Modules/Video/Public/VideoClip.h")]
    [RequiredByNativeCode]
    [StaticAccessor("VideoClipPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct VideoClipPlayable : IEquatable<VideoClipPlayable>, IPlayable
    {
        public static VideoClipPlayable Create(PlayableGraph graph, VideoClip clip, bool looping);
        public PlayableHandle GetHandle();
        public bool Equals(VideoClipPlayable other);
        public VideoClip GetClip();
        public void SetClip(VideoClip value);
        public bool GetLooped();
        public void SetLooped(bool value);
        public bool IsPlaying();
        public double GetStartDelay();
        public double GetPauseDelay();
        public void Seek(double startTime, double startDelay);
        public void Seek(double startTime, double startDelay, [DefaultValue("0")] double duration);

        public static implicit operator Playable(VideoClipPlayable playable);
        public static explicit operator VideoClipPlayable(Playable playable);
    }
}

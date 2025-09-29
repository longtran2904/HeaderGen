#region UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VideoModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Experimental.Audio;
using UnityEngine.Video;

namespace UnityEngine.Experimental.Video
{
    [NativeHeader("Modules/Video/Public/VideoPlayer.h")]
    [NativeHeader("Modules/Video/Public/ScriptBindings/VideoPlayerExtensions.bindings.h")]
    [NativeHeader("VideoScriptingClasses.h")]
    [StaticAccessor("VideoPlayerExtensionsBindings", StaticAccessorType.DoubleColon)]
    public static class VideoPlayerExtensions
    {
        public static AudioSampleProvider GetAudioSampleProvider(this VideoPlayer vp, ushort trackIndex);
    }
}

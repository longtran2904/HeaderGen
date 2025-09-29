#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ExcludeFromObjectFactory]
    [ExcludeFromPreset]
    [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
    public sealed class MovieTexture : Texture
    {
        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public AudioClip audioClip { get; }
        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public bool loop { get; set; }
        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public bool isPlaying { get; }
        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public bool isReadyToPlay { get; }
        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public float duration { get; }

        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public void Play();
        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public void Stop();
        [Obsolete("MovieTexture is removed. Use VideoPlayer instead.", True)]
        public void Pause();
    }
}

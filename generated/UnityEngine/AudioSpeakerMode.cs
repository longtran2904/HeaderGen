#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using System;

namespace UnityEngine
{
    public enum AudioSpeakerMode
    {

        [Obsolete("Raw speaker mode is not supported. Do not use.", True)]
        Raw = 0,
        Mono = 1,
        Stereo = 2,
        Quad = 3,
        Surround = 4,
        Mode5point1 = 5,
        Mode7point1 = 6,
        Prologic = 7
    }
}

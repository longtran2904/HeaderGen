#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

namespace UnityEngine
{
    [RequireComponent(typeof(AudioBehaviour))]
    public sealed class AudioDistortionFilter : Behaviour
    {

        public AudioDistortionFilter();

        public float distortionLevel { get; set; }
    }
}

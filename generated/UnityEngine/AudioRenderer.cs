#region UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioRenderer.bindings.h")]
    public class AudioRenderer
    {
        public AudioRenderer();

        public static bool Start();
        public static bool Stop();
        public static int GetSampleCountForCaptureFrame();
        public static bool Render(NativeArray<float> buffer);
    }
}

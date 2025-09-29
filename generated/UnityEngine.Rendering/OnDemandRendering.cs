#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [RequiredByNativeCode]
    public class OnDemandRendering
    {

        public OnDemandRendering();

        public static bool willCurrentFrameRender { get; }
        public static int renderFrameInterval { get; set; }
        public static int effectiveRenderFrameRate { get; }
    }
}

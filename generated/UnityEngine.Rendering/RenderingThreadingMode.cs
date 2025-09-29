#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
    [MovedFrom("UnityEngine.Experimental.Rendering")]
    public enum RenderingThreadingMode
    {

        Direct = 0,
        SingleThreaded = 1,
        MultiThreaded = 2,
        LegacyJobified = 3,
        NativeGraphicsJobs = 4,
        NativeGraphicsJobsWithoutRenderThread = 5
    }
}

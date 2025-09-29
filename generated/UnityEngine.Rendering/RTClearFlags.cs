#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [Flags]
    public enum RTClearFlags
    {

        None = 0,
        Color = 1,
        Depth = 2,
        Stencil = 4,
        All = 7,
        DepthStencil = 6,
        ColorDepth = 3,
        ColorStencil = 5
    }
}

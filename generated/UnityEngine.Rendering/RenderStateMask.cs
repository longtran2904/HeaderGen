#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [Flags]
    public enum RenderStateMask
    {
        Nothing = 0,
        Blend = 1,
        Raster = 2,
        Depth = 4,
        Stencil = 8,
        Everything = 15
    }
}

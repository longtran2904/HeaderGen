#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    [Flags]
    public enum SortingCriteria
    {
        None = 0,
        SortingLayer = 1,
        RenderQueue = 2,
        BackToFront = 4,
        QuantizedFrontToBack = 8,
        OptimizeStateChanges = 16,
        CanvasOrder = 32,
        RendererPriority = 64,
        CommonOpaque = 59,
        CommonTransparent = 23
    }
}

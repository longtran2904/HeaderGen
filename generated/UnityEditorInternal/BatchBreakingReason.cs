#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditorInternal
{
    [Flags]
    public enum BatchBreakingReason
    {

        NoBreaking = 0,
        NotCoplanarWithCanvas = 1,
        CanvasInjectionIndex = 2,
        DifferentMaterialInstance = 4,
        DifferentRectClipping = 8,
        DifferentTexture = 16,
        DifferentA8TextureUsage = 32,
        DifferentClipRect = 64,
        Unknown = 128
    }
}

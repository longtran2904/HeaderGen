#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class SphereBoundsHandle : PrimitiveBoundsHandle
    {
        [Obsolete("Use parameterless constructor instead.")]
        public SphereBoundsHandle(int controlIDHint);
        public SphereBoundsHandle();

        public float radius { get; set; }

        protected override void DrawWireframe();
        protected override Bounds OnHandleChanged(HandleDirection handle, Bounds boundsOnClick, Bounds newBounds);
    }
}

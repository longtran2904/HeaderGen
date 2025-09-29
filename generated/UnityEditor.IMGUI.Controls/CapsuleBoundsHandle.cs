#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class CapsuleBoundsHandle : PrimitiveBoundsHandle
    {

        [Obsolete("Use parameterless constructor instead.")]
        public CapsuleBoundsHandle(int controlIDHint);
        public CapsuleBoundsHandle();

        public HeightAxis heightAxis { get; set; }
        public float height { get; set; }
        public float radius { get; set; }

        protected override void DrawWireframe();
        protected override Bounds OnHandleChanged(HandleDirection handle, Bounds boundsOnClick, Bounds newBounds);
        public enum HeightAxis
        {

            X = 0,
            Y = 1,
            Z = 2
        }
    }
}

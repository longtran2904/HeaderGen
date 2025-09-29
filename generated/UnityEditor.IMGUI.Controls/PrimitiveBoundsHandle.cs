#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public abstract class PrimitiveBoundsHandle
    {
        [Obsolete("Use parameterless constructor instead.")]
        public PrimitiveBoundsHandle(int controlIDHint);
        public PrimitiveBoundsHandle();

        public Vector3 center { get; set; }
        public Axes axes { get; set; }
        public Color handleColor { get; set; }
        public Color wireframeColor { get; set; }
        public Handles.CapFunction midpointHandleDrawFunction { get; set; }
        public Handles.SizeFunction midpointHandleSizeFunction { get; set; }

        public static float DefaultMidpointHandleSizeFunction(Vector3 position);
        public void SetColor(Color color);
        public void DrawHandle();
        protected abstract void DrawWireframe();
        protected virtual Bounds OnHandleChanged(HandleDirection handle, Bounds boundsOnClick, Bounds newBounds);
        protected Vector3 GetSize();
        protected void SetSize(Vector3 size);
        protected bool IsAxisEnabled(Axes axis);
        protected bool IsAxisEnabled(int vector3Axis);

        [Flags]
        public enum Axes
        {
            None = 0,
            X = 1,
            Y = 2,
            Z = 4,
            All = 7
        }
        protected enum HandleDirection
        {
            PositiveX = 0,
            NegativeX = 1,
            PositiveY = 2,
            NegativeY = 3,
            PositiveZ = 4,
            NegativeZ = 5
        }
    }
}

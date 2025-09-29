#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
    public class BoxBoundsHandle : PrimitiveBoundsHandle
    {

        [Obsolete("Use parameterless constructor instead.")]
        public BoxBoundsHandle(int controlIDHint);
        public BoxBoundsHandle();

        public Vector3 size { get; set; }

        protected override void DrawWireframe();
    }
}

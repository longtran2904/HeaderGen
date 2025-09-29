#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public sealed class DrawGizmo : Attribute
    {

        public Type drawnType;
        public GizmoType drawOptions;

        public DrawGizmo(GizmoType gizmo);
        public DrawGizmo(GizmoType gizmo, Type drawnGizmoType);
    }
}

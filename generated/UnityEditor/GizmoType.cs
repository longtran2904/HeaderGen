#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Flags]
    public enum GizmoType
    {
        Pickable = 1,
        NotInSelectionHierarchy = 2,
        NonSelected = 32,
        Selected = 4,
        Active = 8,
        InSelectionHierarchy = 16,
        [Obsolete("Use NotInSelectionHierarchy instead (UnityUpgradable) -> NotInSelectionHierarchy")]
        NotSelected = -127,
        [Obsolete("Use InSelectionHierarchy instead (UnityUpgradable) -> InSelectionHierarchy")]
        SelectedOrChild = -127
    }
}

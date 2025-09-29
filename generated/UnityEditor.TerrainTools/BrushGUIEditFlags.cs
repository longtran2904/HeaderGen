#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.TerrainTools
{
    [Flags]
    [MovedFrom("UnityEditor.Experimental.TerrainAPI")]
    public enum BrushGUIEditFlags
    {

        None = 0,
        Select = 1,
        Inspect = 2,
        Size = 4,
        Opacity = 8,
        SelectAndInspect = 3,
        All = 15
    }
}

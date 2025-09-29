#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using System;

namespace UnityEngine.AI
{
    [Flags]
    public enum NavMeshBuildDebugFlags
    {

        None = 0,
        InputGeometry = 1,
        Voxels = 2,
        Regions = 4,
        RawContours = 8,
        SimplifiedContours = 16,
        PolygonMeshes = 32,
        PolygonMeshesDetail = 64,
        All = 127
    }
}

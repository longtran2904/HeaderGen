#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using System;

namespace UnityEngine
{
    [Flags]
    public enum TerrainChangedFlags
    {

        Heightmap = 1,
        TreeInstances = 2,
        DelayedHeightmapUpdate = 4,
        FlushEverythingImmediately = 8,
        RemoveDirtyDetailsImmediately = 16,
        HeightmapResolution = 32,
        Holes = 64,
        DelayedHolesUpdate = 128,
        WillBeDestroyed = 256
    }
}

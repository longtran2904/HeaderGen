#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.TerrainUtils
{
    public class TerrainMap
    {
        public TerrainMap();

        public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get; }

        public Terrain GetTerrain(int tileX, int tileZ);
        public static TerrainMap CreateFromConnectedNeighbors(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = True);
        public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = True);
        public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = True);
    }
}

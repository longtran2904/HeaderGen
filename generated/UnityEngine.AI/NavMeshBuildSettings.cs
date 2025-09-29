#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.AI
{
    [NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
    public struct NavMeshBuildSettings
    {
        public int agentTypeID { get; set; }
        public float agentRadius { get; set; }
        public float agentHeight { get; set; }
        public float agentSlope { get; set; }
        public float agentClimb { get; set; }
        public float minRegionArea { get; set; }
        public bool overrideVoxelSize { get; set; }
        public float voxelSize { get; set; }
        public bool overrideTileSize { get; set; }
        public int tileSize { get; set; }
        public uint maxJobWorkers { get; set; }
        public bool preserveTilesOutsideBounds { get; set; }
        public NavMeshBuildDebugSettings debug { get; set; }

        public string[] ValidationReport(Bounds buildBounds);
    }
}

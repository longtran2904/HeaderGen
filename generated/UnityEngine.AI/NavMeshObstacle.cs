#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
    [MovedFrom("UnityEngine")]
    [NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
    public sealed class NavMeshObstacle : Behaviour
    {
        public NavMeshObstacle();

        public float height { get; set; }
        public float radius { get; set; }
        public Vector3 velocity { get; set; }
        public bool carving { get; set; }
        public bool carveOnlyStationary { get; set; }
        [NativeProperty("MoveThreshold")]
        public float carvingMoveThreshold { get; set; }
        [NativeProperty("TimeToStationary")]
        public float carvingTimeToStationary { get; set; }
        public NavMeshObstacleShape shape { get; set; }
        public Vector3 center { get; set; }
        public Vector3 size { get; set; }
    }
}

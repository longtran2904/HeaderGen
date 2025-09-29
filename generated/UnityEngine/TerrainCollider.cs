#region UnityEngine.TerrainPhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainPhysicsModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Terrain/Public/TerrainData.h")]
    [NativeHeader("Modules/TerrainPhysics/TerrainCollider.h")]
    public class TerrainCollider : Collider
    {

        public TerrainCollider();

        public TerrainData terrainData { get; set; }
    }
}

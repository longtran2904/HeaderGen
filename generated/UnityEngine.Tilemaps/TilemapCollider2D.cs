#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps
{
    [NativeType(Header = "Modules/Tilemap/Public/TilemapCollider2D.h")]
    [RequireComponent(typeof(Tilemap))]
    public sealed class TilemapCollider2D : Collider2D
    {
        public TilemapCollider2D();

        public uint maximumTileChangeCount { get; set; }
        public float extrusionFactor { get; set; }
        public bool hasTilemapChanges { get; }

        [NativeMethod(Name = "ProcessTileChangeQueue")]
        public void ProcessTilemapChanges();
    }
}

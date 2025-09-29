#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
    [NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
    [RequiredByNativeCode]
    public struct TileChangeData
    {
        public TileChangeData(Vector3Int position, TileBase tile, Color color, Matrix4x4 transform);

        public Vector3Int position { get; set; }
        public TileBase tile { get; set; }
        public Color color { get; set; }
        public Matrix4x4 transform { get; set; }
    }
}

#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
    [RequiredByNativeCode]
    public class ITilemap
    {

        public Vector3Int origin { get; }
        public Vector3Int size { get; }
        public Bounds localBounds { get; }
        public BoundsInt cellBounds { get; }

        public virtual Sprite GetSprite(Vector3Int position);
        public virtual Color GetColor(Vector3Int position);
        public virtual Matrix4x4 GetTransformMatrix(Vector3Int position);
        public virtual TileFlags GetTileFlags(Vector3Int position);
        public virtual TileBase GetTile(Vector3Int position);
        public virtual T GetTile<T>(Vector3Int position) where T : TileBase;
        public void RefreshTile(Vector3Int position);
        public T GetComponent<T>();
    }
}

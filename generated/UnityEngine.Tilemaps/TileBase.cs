#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
    [RequiredByNativeCode]
    public abstract class TileBase : ScriptableObject
    {
        protected TileBase();

        [RequiredByNativeCode]
        public virtual void RefreshTile(Vector3Int position, ITilemap tilemap);
        [RequiredByNativeCode]
        public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData);
        [RequiredByNativeCode]
        public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData);
        [RequiredByNativeCode]
        public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go);
    }
}

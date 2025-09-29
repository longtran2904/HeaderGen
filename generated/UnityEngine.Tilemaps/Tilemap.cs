#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
    [NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
    [NativeHeader("Modules/Grid/Public/Grid.h")]
    [NativeHeader("Runtime/Graphics/SpriteFrame.h")]
    [NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
    [NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
    [NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class Tilemap : GridLayout
    {

        public Tilemap();

        public Grid layoutGrid { get; }
        public BoundsInt cellBounds { get; }
        [NativeProperty("TilemapBoundsScripting")]
        public Bounds localBounds { get; }
        public float animationFrameRate { get; set; }
        public Color color { get; set; }
        public Vector3Int origin { get; set; }
        public Vector3Int size { get; set; }
        [NativeProperty(Name = "TileAnchorScripting")]
        public Vector3 tileAnchor { get; set; }
        public Orientation orientation { get; set; }
        public Matrix4x4 orientationMatrix { get; set; }
        public Vector3Int editorPreviewOrigin { get; }
        public Vector3Int editorPreviewSize { get; }

        public static event Action<Tilemap, SyncTile[]> tilemapTileChanged;

        public Vector3 GetCellCenterLocal(Vector3Int position);
        public Vector3 GetCellCenterWorld(Vector3Int position);
        public TileBase GetTile(Vector3Int position);
        public T GetTile<T>(Vector3Int position) where T : TileBase;
        public TileBase[] GetTilesBlock(BoundsInt bounds);
        public int GetTilesBlockNonAlloc(BoundsInt bounds, TileBase[] tiles);
        public int GetTilesRangeCount(Vector3Int startPosition, Vector3Int endPosition);
        public int GetTilesRangeNonAlloc(Vector3Int startPosition, Vector3Int endPosition, Vector3Int[] positions, TileBase[] tiles);
        public void SetTile(Vector3Int position, TileBase tile);
        public void SetTiles(Vector3Int[] positionArray, TileBase[] tileArray);
        public void SetTilesBlock(BoundsInt position, TileBase[] tileArray);
        [NativeMethod(Name = "SetTileChangeData")]
        public void SetTile(TileChangeData tileChangeData, bool ignoreLockFlags);
        [NativeMethod(Name = "SetTileChangeDataArray")]
        public void SetTiles(TileChangeData[] tileChangeDataArray, bool ignoreLockFlags);
        public bool HasTile(Vector3Int position);
        [NativeMethod(Name = "RefreshTileAsset")]
        public void RefreshTile(Vector3Int position);
        [NativeMethod(Name = "RefreshAllTileAssets")]
        public void RefreshAllTiles();
        public void SwapTile(TileBase changeTile, TileBase newTile);
        public bool ContainsTile(TileBase tileAsset);
        public int GetUsedTilesCount();
        public int GetUsedSpritesCount();
        public int GetUsedTilesNonAlloc(TileBase[] usedTiles);
        public int GetUsedSpritesNonAlloc(Sprite[] usedSprites);
        public Sprite GetSprite(Vector3Int position);
        public Matrix4x4 GetTransformMatrix(Vector3Int position);
        public void SetTransformMatrix(Vector3Int position, Matrix4x4 transform);
        [NativeMethod(Name = "GetTileColor")]
        public Color GetColor(Vector3Int position);
        [NativeMethod(Name = "SetTileColor")]
        public void SetColor(Vector3Int position, Color color);
        public TileFlags GetTileFlags(Vector3Int position);
        public void SetTileFlags(Vector3Int position, TileFlags flags);
        public void AddTileFlags(Vector3Int position, TileFlags flags);
        public void RemoveTileFlags(Vector3Int position, TileFlags flags);
        [NativeMethod(Name = "GetTileInstantiatedObject")]
        public GameObject GetInstantiatedObject(Vector3Int position);
        [NativeMethod(Name = "GetTileObjectToInstantiate")]
        public GameObject GetObjectToInstantiate(Vector3Int position);
        [NativeMethod(Name = "SetTileColliderType")]
        public void SetColliderType(Vector3Int position, Tile.ColliderType colliderType);
        [NativeMethod(Name = "GetTileColliderType")]
        public Tile.ColliderType GetColliderType(Vector3Int position);
        [NativeMethod(Name = "GetTileAnimationFrameCount")]
        public int GetAnimationFrameCount(Vector3Int position);
        [NativeMethod(Name = "GetTileAnimationFrame")]
        public int GetAnimationFrame(Vector3Int position);
        [NativeMethod(Name = "SetTileAnimationFrame")]
        public void SetAnimationFrame(Vector3Int position, int frame);
        [NativeMethod(Name = "GetTileAnimationTime")]
        public float GetAnimationTime(Vector3Int position);
        [NativeMethod(Name = "SetTileAnimationTime")]
        public void SetAnimationTime(Vector3Int position, float time);
        public void FloodFill(Vector3Int position, TileBase tile);
        public void BoxFill(Vector3Int position, TileBase tile, int startX, int startY, int endX, int endY);
        public void InsertCells(Vector3Int position, Vector3Int insertCells);
        public void InsertCells(Vector3Int position, int numColumns, int numRows, int numLayers);
        public void DeleteCells(Vector3Int position, Vector3Int deleteCells);
        public void DeleteCells(Vector3Int position, int numColumns, int numRows, int numLayers);
        public void ClearAllTiles();
        public void ResizeBounds();
        public void CompressBounds();
        public TileBase GetEditorPreviewTile(Vector3Int position);
        public T GetEditorPreviewTile<T>(Vector3Int position) where T : TileBase;
        public void SetEditorPreviewTile(Vector3Int position, TileBase tile);
        public bool HasEditorPreviewTile(Vector3Int position);
        public Sprite GetEditorPreviewSprite(Vector3Int position);
        public Matrix4x4 GetEditorPreviewTransformMatrix(Vector3Int position);
        public void SetEditorPreviewTransformMatrix(Vector3Int position, Matrix4x4 transform);
        [NativeMethod(Name = "GetEditorPreviewTileColor")]
        public Color GetEditorPreviewColor(Vector3Int position);
        [NativeMethod(Name = "SetEditorPreviewTileColor")]
        public void SetEditorPreviewColor(Vector3Int position, Color color);
        public TileFlags GetEditorPreviewTileFlags(Vector3Int position);
        public void EditorPreviewFloodFill(Vector3Int position, TileBase tile);
        public void EditorPreviewBoxFill(Vector3Int position, Object tile, int startX, int startY, int endX, int endY);
        [NativeMethod(Name = "ClearAllEditorPreviewTileAssets")]
        public void ClearAllEditorPreviewTiles();
        public enum Orientation
        {

            XY = 0,
            XZ = 1,
            YX = 2,
            YZ = 3,
            ZX = 4,
            ZY = 5,
            Custom = 6
        }
        [RequiredByNativeCode]
        public struct SyncTile
        {

            public Vector3Int position { get; }
            public TileBase tile { get; }
            public TileData tileData { get; }
        }
    }
}

#region UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Tilemaps
{
    [NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
    [NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
    [NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
    [NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
    [RequireComponent(typeof(Tilemap))]
    public sealed class TilemapRenderer : Renderer
    {

        public TilemapRenderer();

        public Vector3Int chunkSize { get; set; }
        public Vector3 chunkCullingBounds { get; set; }
        public int maxChunkCount { get; set; }
        public int maxFrameAge { get; set; }
        public SortOrder sortOrder { get; set; }
        [NativeProperty("RenderMode")]
        public Mode mode { get; set; }
        public DetectChunkCullingBounds detectChunkCullingBounds { get; set; }
        public SpriteMaskInteraction maskInteraction { get; set; }
        public enum SortOrder
        {

            BottomLeft = 0,
            BottomRight = 1,
            TopLeft = 2,
            TopRight = 3
        }
        public enum Mode
        {

            Chunk = 0,
            Individual = 1
        }
        public enum DetectChunkCullingBounds
        {

            Auto = 0,
            Manual = 1
        }
    }
}

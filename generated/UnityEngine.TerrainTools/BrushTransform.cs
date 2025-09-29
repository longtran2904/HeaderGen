#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.TerrainTools
{
    [MovedFrom("UnityEngine.Experimental.TerrainAPI")]
    public struct BrushTransform
    {
        public BrushTransform(Vector2 brushOrigin, Vector2 brushU, Vector2 brushV);

        public Vector2 brushOrigin { get; }
        public Vector2 brushU { get; }
        public Vector2 brushV { get; }
        public Vector2 targetOrigin { get; }
        public Vector2 targetX { get; }
        public Vector2 targetY { get; }

        public Rect GetBrushXYBounds();
        public static BrushTransform FromRect(Rect brushRect);
        public Vector2 ToBrushUV(Vector2 targetXY);
        public Vector2 FromBrushUV(Vector2 brushUV);
    }
}

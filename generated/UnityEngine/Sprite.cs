#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [ExcludeFromPreset]
    [NativeHeader("Runtime/Graphics/SpriteUtility.h")]
    [NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
    [NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
    [NativeType("Runtime/Graphics/SpriteFrame.h")]
    public sealed class Sprite : Object
    {

        public Bounds bounds { get; }
        public Rect rect { get; }
        public Vector4 border { get; }
        public Texture2D texture { get; }
        public float pixelsPerUnit { get; }
        public float spriteAtlasTextureScale { get; }
        public Texture2D associatedAlphaSplitTexture { get; }
        public Vector2 pivot { get; }
        public bool packed { get; }
        public SpritePackingMode packingMode { get; }
        public SpritePackingRotation packingRotation { get; }
        public Rect textureRect { get; }
        public Vector2 textureRectOffset { get; }
        public Vector2[] vertices { get; }
        public ushort[] triangles { get; }
        public Vector2[] uv { get; }

        public int GetPhysicsShapeCount();
        public int GetPhysicsShapePointCount(int shapeIdx);
        public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape);
        public void OverridePhysicsShape(IList<Vector2[]> physicsShapes);
        [FreeFunction("SpritesBindings::OverrideGeometry", HasExplicitThis = True)]
        public void OverrideGeometry([NotNull("ArgumentNullException")][Unmarshalled] Vector2[] vertices, [NotNull("ArgumentNullException")][Unmarshalled] ushort[] triangles);
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape);
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border);
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType);
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude);
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit);
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot);
    }
}

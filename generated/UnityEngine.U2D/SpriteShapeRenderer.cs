#region UnityEngine.SpriteShapeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SpriteShapeModule.dll
#endregion

using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
    [MovedFrom("UnityEngine.Experimental.U2D")]
    [NativeType(Header = "Modules/SpriteShape/Public/SpriteShapeRenderer.h")]
    public class SpriteShapeRenderer : Renderer
    {

        public SpriteShapeRenderer();

        public Color color { get; set; }
        public SpriteMaskInteraction maskInteraction { get; set; }

        public void Prepare(JobHandle handle, SpriteShapeParameters shapeParams, Sprite[] sprites);
        public void SetLocalAABB(Bounds bounds);
        public NativeArray<Bounds> GetBounds();
        public NativeArray<SpriteShapeSegment> GetSegments(int dataSize);
        public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords);
        public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents);
        public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents, out NativeSlice<Vector3> normals);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.U2D
{
    [NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
    [NativeHeader("Runtime/Graphics/SpriteFrame.h")]
    public static class SpriteDataAccessExtensions
    {
        public static NativeSlice<T> GetVertexAttribute<T>(this Sprite sprite, VertexAttribute channel) where T : struct;
        public static void SetVertexAttribute<T>(this Sprite sprite, VertexAttribute channel, NativeArray<T> src) where T : struct;
        public static NativeArray<Matrix4x4> GetBindPoses(this Sprite sprite);
        public static void SetBindPoses(this Sprite sprite, NativeArray<Matrix4x4> src);
        public static NativeArray<ushort> GetIndices(this Sprite sprite);
        public static void SetIndices(this Sprite sprite, NativeArray<ushort> src);
        public static SpriteBone[] GetBones(this Sprite sprite);
        public static void SetBones(this Sprite sprite, SpriteBone[] src);
        [NativeName("HasChannel")]
        public static bool HasVertexAttribute([NotNull("ArgumentNullException")] this Sprite sprite, VertexAttribute channel);
        public static void SetVertexCount([NotNull("ArgumentNullException")] this Sprite sprite, int count);
        public static int GetVertexCount([NotNull("ArgumentNullException")] this Sprite sprite);
    }
}

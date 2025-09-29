#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
    public class PowerOfTwoTextureAtlas : Texture2DAtlas
    {

        public PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, string name = "", bool useMipMap = True);

        public int mipPadding { get; }

        public Vector4 GetPayloadScaleOffset(Texture texture, in Vector4 scaleOffset);
        public static Vector4 GetPayloadScaleOffset(in Vector2 textureSize, in Vector2 paddingSize, in Vector4 scaleOffset);
        public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1);
        public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1);
        public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1);
        public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1);
        public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1);
        public void ResetRequestedTexture();
        public bool ReserveSpace(Texture texture);
        public bool ReserveSpace(Texture texture, int width, int height);
        public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height);
        public bool RelayoutEntries();
        public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format);
        public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format);
    }
}

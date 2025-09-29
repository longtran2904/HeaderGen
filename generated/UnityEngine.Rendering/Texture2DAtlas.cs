#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
    public class Texture2DAtlas
    {

        public Texture2DAtlas(int width, int height, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, bool powerOfTwoPadding = False, string name = "", bool useMipMap = True);

        public static int maxMipLevelPadding { get; }
        public RTHandle AtlasTexture { get; }

        public void Release();
        public void ResetAllocator();
        public void ClearTarget(CommandBuffer cmd);
        public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1);
        public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = True, int overrideInstanceID = -1);
        public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = True, int overrideInstanceID = -1);
        public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1);
        public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset);
        public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset);
        public int GetTextureID(Texture texture);
        public int GetTextureID(Texture textureA, Texture textureB);
        public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB);
        public bool IsCached(out Vector4 scaleOffset, Texture texture);
        public bool IsCached(out Vector4 scaleOffset, int id);
        public virtual bool NeedsUpdate(Texture texture, bool needMips = False);
        public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = False);
        public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture);
        public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = True, bool blitMips = True);
        public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = True, bool blitMips = True);
    }
}

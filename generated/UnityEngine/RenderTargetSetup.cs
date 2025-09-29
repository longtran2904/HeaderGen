#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine
{
    public struct RenderTargetSetup
    {
        public RenderBuffer[] color;
        public RenderBuffer depth;
        public int mipLevel;
        public CubemapFace cubemapFace;
        public int depthSlice;
        public RenderBufferLoadAction[] colorLoad;
        public RenderBufferStoreAction[] colorStore;
        public RenderBufferLoadAction depthLoad;
        public RenderBufferStoreAction depthStore;

        public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, RenderBufferLoadAction[] colorLoad, RenderBufferStoreAction[] colorStore, RenderBufferLoadAction depthLoad, RenderBufferStoreAction depthStore);
        public RenderTargetSetup(RenderBuffer color, RenderBuffer depth);
        public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel);
        public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face);
        public RenderTargetSetup(RenderBuffer color, RenderBuffer depth, int mipLevel, CubemapFace face, int depthSlice);
        public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth);
        public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mipLevel);
        public RenderTargetSetup(RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face);
    }
}

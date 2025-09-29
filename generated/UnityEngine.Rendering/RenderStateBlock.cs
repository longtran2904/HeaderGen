#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct RenderStateBlock : IEquatable<RenderStateBlock>
    {

        public RenderStateBlock(RenderStateMask mask);

        public BlendState blendState { get; set; }
        public RasterState rasterState { get; set; }
        public DepthState depthState { get; set; }
        public StencilState stencilState { get; set; }
        public int stencilReference { get; set; }
        public RenderStateMask mask { get; set; }

        public bool Equals(RenderStateBlock other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(RenderStateBlock left, RenderStateBlock right);
        public static bool operator !=(RenderStateBlock left, RenderStateBlock right);
    }
}

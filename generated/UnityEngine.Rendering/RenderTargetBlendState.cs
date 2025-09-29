#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct RenderTargetBlendState : IEquatable<RenderTargetBlendState>
    {
        public RenderTargetBlendState(ColorWriteMask writeMask = ColorWriteMask.All, BlendMode sourceColorBlendMode = BlendMode.One, BlendMode destinationColorBlendMode = BlendMode.Zero, BlendMode sourceAlphaBlendMode = BlendMode.One, BlendMode destinationAlphaBlendMode = BlendMode.Zero, BlendOp colorBlendOperation = BlendOp.Add, BlendOp alphaBlendOperation = BlendOp.Add);

        public static RenderTargetBlendState defaultValue { get; }
        public ColorWriteMask writeMask { get; set; }
        public BlendMode sourceColorBlendMode { get; set; }
        public BlendMode destinationColorBlendMode { get; set; }
        public BlendMode sourceAlphaBlendMode { get; set; }
        public BlendMode destinationAlphaBlendMode { get; set; }
        public BlendOp colorBlendOperation { get; set; }
        public BlendOp alphaBlendOperation { get; set; }

        public bool Equals(RenderTargetBlendState other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(RenderTargetBlendState left, RenderTargetBlendState right);
        public static bool operator !=(RenderTargetBlendState left, RenderTargetBlendState right);
    }
}

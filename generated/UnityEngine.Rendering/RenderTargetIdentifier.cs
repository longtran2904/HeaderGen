#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
    {
        public const int AllDepthSlices = -1;

        public RenderTargetIdentifier(BuiltinRenderTextureType type);
        public RenderTargetIdentifier(BuiltinRenderTextureType type, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0);
        public RenderTargetIdentifier(string name);
        public RenderTargetIdentifier(string name, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0);
        public RenderTargetIdentifier(int nameID);
        public RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0);
        public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0);
        public RenderTargetIdentifier(Texture tex);
        public RenderTargetIdentifier(Texture tex, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0);
        public RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0);

        public override string ToString();
        public override int GetHashCode();
        public bool Equals(RenderTargetIdentifier rhs);
        public override bool Equals(object obj);

        public static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs);
        public static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs);

        public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type);
        public static implicit operator RenderTargetIdentifier(string name);
        public static implicit operator RenderTargetIdentifier(int nameID);
        public static implicit operator RenderTargetIdentifier(Texture tex);
        public static implicit operator RenderTargetIdentifier(RenderBuffer buf);
    }
}

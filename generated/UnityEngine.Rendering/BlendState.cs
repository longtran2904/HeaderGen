#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct BlendState : IEquatable<BlendState>
    {

        public BlendState(bool separateMRTBlend = False, bool alphaToMask = False);

        public static BlendState defaultValue { get; }
        public bool separateMRTBlendStates { get; set; }
        public bool alphaToMask { get; set; }
        public RenderTargetBlendState blendState0 { get; set; }
        public RenderTargetBlendState blendState1 { get; set; }
        public RenderTargetBlendState blendState2 { get; set; }
        public RenderTargetBlendState blendState3 { get; set; }
        public RenderTargetBlendState blendState4 { get; set; }
        public RenderTargetBlendState blendState5 { get; set; }
        public RenderTargetBlendState blendState6 { get; set; }
        public RenderTargetBlendState blendState7 { get; set; }

        public bool Equals(BlendState other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(BlendState left, BlendState right);
        public static bool operator !=(BlendState left, BlendState right);
    }
}

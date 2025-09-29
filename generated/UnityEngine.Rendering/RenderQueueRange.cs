#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public struct RenderQueueRange : IEquatable<RenderQueueRange>
    {

        public static readonly int minimumBound;
        public static readonly int maximumBound;

        public RenderQueueRange(int lowerBound, int upperBound);

        public static RenderQueueRange all { get; }
        public static RenderQueueRange opaque { get; }
        public static RenderQueueRange transparent { get; }
        public int lowerBound { get; set; }
        public int upperBound { get; set; }

        public bool Equals(RenderQueueRange other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(RenderQueueRange left, RenderQueueRange right);
        public static bool operator !=(RenderQueueRange left, RenderQueueRange right);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Internal;

namespace UnityEngine.Rendering
{
    public struct FilteringSettings : IEquatable<FilteringSettings>
    {
        public FilteringSettings([DefaultValue("RenderQueueRange.all")] RenderQueueRange? renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = 4294967295, int excludeMotionVectorObjects = 0);

        public static FilteringSettings defaultValue { get; }
        public RenderQueueRange renderQueueRange { get; set; }
        public int layerMask { get; set; }
        public uint renderingLayerMask { get; set; }
        public bool excludeMotionVectorObjects { get; set; }
        public SortingLayerRange sortingLayerRange { get; set; }

        public bool Equals(FilteringSettings other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(FilteringSettings left, FilteringSettings right);
        public static bool operator !=(FilteringSettings left, FilteringSettings right);
    }
}

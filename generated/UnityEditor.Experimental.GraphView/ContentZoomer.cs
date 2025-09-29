#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.Experimental.GraphView
{
    public class ContentZoomer : Manipulator
    {

        public static readonly float DefaultReferenceScale;
        public static readonly float DefaultMinScale;
        public static readonly float DefaultMaxScale;
        public static readonly float DefaultScaleStep;

        public ContentZoomer();

        public float referenceScale { get; set; }
        public float minScale { get; set; }
        public float maxScale { get; set; }
        public float scaleStep { get; set; }
        [Obsolete("ContentZoomer.keepPixelCacheOnZoom is deprecated and has no effect")]
        public bool keepPixelCacheOnZoom { get; set; }

        protected override void RegisterCallbacksOnTarget();
        protected override void UnregisterCallbacksFromTarget();
    }
}

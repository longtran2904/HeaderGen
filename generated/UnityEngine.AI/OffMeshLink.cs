#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
    [MovedFrom("UnityEngine")]
    public sealed class OffMeshLink : Behaviour
    {
        public OffMeshLink();

        public bool activated { get; set; }
        public bool occupied { get; }
        public float costOverride { get; set; }
        public bool biDirectional { get; set; }
        [Obsolete("Use area instead.")]
        public int navMeshLayer { get; set; }
        public int area { get; set; }
        public bool autoUpdatePositions { get; set; }
        public Transform startTransform { get; set; }
        public Transform endTransform { get; set; }

        public void UpdatePositions();
    }
}

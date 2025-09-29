#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
    [MovedFrom("UnityEngine")]
    public struct NavMeshHit
    {

        public Vector3 position { get; set; }
        public Vector3 normal { get; set; }
        public float distance { get; set; }
        public int mask { get; set; }
        public bool hit { get; set; }
    }
}

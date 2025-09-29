#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

namespace UnityEngine.AI
{
    public struct NavMeshLinkData
    {

        public Vector3 startPosition { get; set; }
        public Vector3 endPosition { get; set; }
        public float costModifier { get; set; }
        public bool bidirectional { get; set; }
        public float width { get; set; }
        public int area { get; set; }
        public int agentTypeID { get; set; }
    }
}

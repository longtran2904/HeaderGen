#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

namespace UnityEngine.AI
{
    public struct NavMeshQueryFilter
    {
        public int areaMask { get; set; }
        public int agentTypeID { get; set; }

        public float GetAreaCost(int areaIndex);
        public void SetAreaCost(int areaIndex, float cost);
    }
}

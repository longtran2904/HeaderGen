#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using Unity.Jobs;
using UnityEngine.Bindings;

namespace UnityEngine.Experimental.AI
{
    [StaticAccessor("NavMeshWorldBindings", StaticAccessorType.DoubleColon)]
    public struct NavMeshWorld
    {

        public bool IsValid();
        public static NavMeshWorld GetDefaultWorld();
        public void AddDependency(JobHandle job);
    }
}

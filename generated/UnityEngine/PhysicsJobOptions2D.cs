#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeClass("PhysicsJobOptions2D", "struct PhysicsJobOptions2D;")]
    [NativeHeader("Modules/Physics2D/Public/Physics2DSettings.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct PhysicsJobOptions2D
    {
        public bool useMultithreading { get; set; }
        public bool useConsistencySorting { get; set; }
        public int interpolationPosesPerJob { get; set; }
        public int newContactsPerJob { get; set; }
        public int collideContactsPerJob { get; set; }
        public int clearFlagsPerJob { get; set; }
        public int clearBodyForcesPerJob { get; set; }
        public int syncDiscreteFixturesPerJob { get; set; }
        public int syncContinuousFixturesPerJob { get; set; }
        public int findNearestContactsPerJob { get; set; }
        public int updateTriggerContactsPerJob { get; set; }
        public int islandSolverCostThreshold { get; set; }
        public int islandSolverBodyCostScale { get; set; }
        public int islandSolverContactCostScale { get; set; }
        public int islandSolverJointCostScale { get; set; }
        public int islandSolverBodiesPerJob { get; set; }
        public int islandSolverContactsPerJob { get; set; }
    }
}

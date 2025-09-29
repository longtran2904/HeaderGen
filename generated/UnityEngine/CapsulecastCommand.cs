#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/BatchCommands/CapsulecastCommand.h")]
    [NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
    public struct CapsulecastCommand
    {
        public CapsulecastCommand(Vector3 p1, Vector3 p2, float radius, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5);
        public CapsulecastCommand(PhysicsScene physicsScene, Vector3 p1, Vector3 p2, float radius, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5);

        public Vector3 point1 { get; set; }
        public Vector3 point2 { get; set; }
        public float radius { get; set; }
        public Vector3 direction { get; set; }
        public float distance { get; set; }
        public int layerMask { get; set; }
        public PhysicsScene physicsScene { get; set; }

        public static JobHandle ScheduleBatch(NativeArray<CapsulecastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = null);
    }
}

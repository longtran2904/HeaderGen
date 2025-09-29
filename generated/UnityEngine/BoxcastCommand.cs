#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/BatchCommands/BoxcastCommand.h")]
    [NativeHeader("Runtime/Jobs/ScriptBindings/JobsBindingsTypes.h")]
    public struct BoxcastCommand
    {
        public BoxcastCommand(Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5);
        public BoxcastCommand(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, float distance = 3.4028235E+38, int layerMask = -5);

        public Vector3 center { get; set; }
        public Vector3 halfExtents { get; set; }
        public Quaternion orientation { get; set; }
        public Vector3 direction { get; set; }
        public float distance { get; set; }
        public int layerMask { get; set; }
        public PhysicsScene physicsScene { get; set; }

        public static JobHandle ScheduleBatch(NativeArray<BoxcastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn = null);
    }
}

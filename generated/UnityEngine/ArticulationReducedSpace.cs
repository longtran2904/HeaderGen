#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [NativeHeader("Modules/Physics/ArticulationBody.h")]
    public struct ArticulationReducedSpace
    {
        public int dofCount;

        public ArticulationReducedSpace(float a);
        public ArticulationReducedSpace(float a, float b);
        public ArticulationReducedSpace(float a, float b, float c);

        public float this[int i] { get; set; }
    }
}

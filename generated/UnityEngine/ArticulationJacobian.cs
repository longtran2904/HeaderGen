#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [NativeHeader("Modules/Physics/ArticulationBody.h")]
    public struct ArticulationJacobian
    {
        public ArticulationJacobian(int rows, int cols);

        public float this[int row, int col] { get; set; }
        public int rows { get; set; }
        public int columns { get; set; }
        public List<float> elements { get; set; }
    }
}

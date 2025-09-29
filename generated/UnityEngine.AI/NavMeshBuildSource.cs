#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.AI
{
    [NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
    [UsedByNativeCode]
    public struct NavMeshBuildSource
    {
        public Matrix4x4 transform { get; set; }
        public Vector3 size { get; set; }
        public NavMeshBuildSourceShape shape { get; set; }
        public int area { get; set; }
        public Object sourceObject { get; set; }
        public Component component { get; set; }
    }
}

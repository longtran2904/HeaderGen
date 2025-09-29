#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
    [MovedFrom("UnityEngine")]
    [NativeHeader("Modules/AI/NavMeshPath.bindings.h")]
    public sealed class NavMeshPath
    {
        public NavMeshPath();

        ~NavMeshPath();

        public Vector3[] corners { get; }
        public NavMeshPathStatus status { get; }

        [FreeFunction("NavMeshPathScriptBindings::GetCornersNonAlloc", HasExplicitThis = True)]
        public int GetCornersNonAlloc(out Vector3[] results);
        public void ClearCorners();
    }
}

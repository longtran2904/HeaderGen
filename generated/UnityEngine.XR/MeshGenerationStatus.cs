#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
    [RequiredByNativeCode]
    public enum MeshGenerationStatus
    {

        Success = 0,
        InvalidMeshId = 1,
        GenerationAlreadyInProgress = 2,
        Canceled = 3,
        UnknownError = 4
    }
}

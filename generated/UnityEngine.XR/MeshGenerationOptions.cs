#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [Flags]
    [NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
    [UsedByNativeCode]
    public enum MeshGenerationOptions
    {

        None = 0,
        ConsumeTransform = 1
    }
}

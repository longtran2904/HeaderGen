#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeType("Runtime/GfxDevice/GfxDeviceTypes.h")]
    public enum ComputeBufferMode
    {

        Immutable = 0,
        Dynamic = 1,
        [Obsolete("ComputeBufferMode.Circular is deprecated (legacy mode)")]
        Circular = 2,
        [Obsolete("ComputeBufferMode.StreamOut is deprecated (internal use only)")]
        StreamOut = 3,
        SubUpdates = 4
    }
}

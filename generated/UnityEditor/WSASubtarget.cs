#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Runtime/Serialize/BuildTarget.h")]
    [Obsolete("WSASubtarget is obsolete and has no effect. It will be removed in a subsequent Unity release.")]
    public enum WSASubtarget
    {

        AnyDevice = 0,
        PC = 1,
        Mobile = 2,
        HoloLens = 3
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Profiling.Memory.Experimental
{
    [Flags]
    public enum TypeFlags
    {

        kNone = 0,
        kValueType = 1,
        kArray = 2,
        kArrayRankMask = -65536
    }
}

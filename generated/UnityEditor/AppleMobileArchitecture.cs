#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    [Flags]
    public enum AppleMobileArchitecture
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ARMv7 is no longer supported", True)]
        ARMv7 = 0,
        ARM64 = 1,
        Universal = 2
    }
}

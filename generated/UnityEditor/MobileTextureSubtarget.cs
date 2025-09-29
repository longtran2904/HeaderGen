#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Runtime/Serialize/BuildTarget.h")]
    public enum MobileTextureSubtarget
    {

        Generic = 0,
        DXT = 1,
        PVRTC = 2,
        [Obsolete("UnityEditor.MobileTextureSubtarget.ATC has been deprecated. Use UnityEditor.MobileTextureSubtarget.ETC instead (UnityUpgradable) -> UnityEditor.MobileTextureSubtarget.ETC", True)]
        ATC = 3,
        ETC = 4,
        ETC2 = 5,
        ASTC = 6
    }
}

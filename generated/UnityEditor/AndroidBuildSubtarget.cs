#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [NativeType(Header = "Editor/Src/EditorUserBuildSettings.h")]
    [Obsolete("UnityEditor.AndroidBuildSubtarget has been deprecated. Use UnityEditor.MobileTextureSubtarget instead (UnityUpgradable)", True)]
    public enum AndroidBuildSubtarget
    {

        Generic = -1,
        DXT = -1,
        PVRTC = -1,
        ATC = -1,
        ETC = -1,
        ETC2 = -1,
        ASTC = -1
    }
}

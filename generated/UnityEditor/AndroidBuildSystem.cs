#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Editor/Src/EditorUserBuildSettings.h")]
    public enum AndroidBuildSystem
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Internal build system has been deprecated. Use Gradle instead (UnityUpgradable) -> UnityEditor.AndroidBuildSystem.Gradle", True)]
        Internal = 0,
        Gradle = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ADT/eclipse project export for Android is no longer supported - please use Gradle export instead", True)]
        ADT = 2,
        VisualStudio = 3
    }
}

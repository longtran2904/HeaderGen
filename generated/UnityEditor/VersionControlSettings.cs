#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/VersionControlSettings.h")]
    [NativeHeader("Editor/Src/EditorUserSettings.h")]
    public sealed class VersionControlSettings : UnityEngine.Object
    {

        [ExcludeFromDocs]
        [StaticAccessor("GetVersionControlSettings()", StaticAccessorType.Dot)]
        public static string mode { get; set; }
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Runtime/Serialize/BuildTarget.h")]
    public enum StandaloneBuildSubtarget
    {

        Player = 0,
        Server = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        NoSubtarget = -1
    }
}

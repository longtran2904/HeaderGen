#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/LODUtility.bindings.h")]
    public sealed class LODUtility
    {

        public LODUtility();

        public static void CalculateLODGroupBoundingBox(LODGroup group);
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/Unwrapping.bindings.h")]
    public struct UnwrapParam
    {

        public float angleError;
        public float areaError;
        public float hardAngle;
        public float packMargin;

        [FreeFunction("ResetUnwrapParam")]
        public static void SetDefaults(out UnwrapParam param);
    }
}

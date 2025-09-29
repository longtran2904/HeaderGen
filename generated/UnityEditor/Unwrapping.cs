#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/Unwrapping.bindings.h")]
    public static class Unwrapping
    {

        public static Vector2[] GeneratePerTriangleUV(Mesh src);
        public static Vector2[] GeneratePerTriangleUV(Mesh src, UnwrapParam settings);
        public static void GenerateSecondaryUVSet(Mesh src);
        public static void GenerateSecondaryUVSet(Mesh src, UnwrapParam settings);
    }
}

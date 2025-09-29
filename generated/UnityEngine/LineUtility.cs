#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Export/Graphics/LineUtility.bindings.h")]
    public sealed class LineUtility
    {
        public LineUtility();

        public static void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep);
        public static void Simplify(List<Vector3> points, float tolerance, List<Vector3> simplifiedPoints);
        public static void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep);
        public static void Simplify(List<Vector2> points, float tolerance, List<Vector2> simplifiedPoints);
    }
}

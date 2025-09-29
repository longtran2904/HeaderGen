#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/OptimizeTransformHierarchy.h")]
    public class AnimatorUtility
    {
        public AnimatorUtility();

        [FreeFunction]
        public static void OptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go, string[] exposedTransforms);
        [FreeFunction]
        public static void DeoptimizeTransformHierarchy([NotNull("NullExceptionObject")] GameObject go);
    }
}

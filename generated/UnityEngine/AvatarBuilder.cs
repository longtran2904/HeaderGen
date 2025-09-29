#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
    public class AvatarBuilder
    {
        public AvatarBuilder();

        public static Avatar BuildHumanAvatar(GameObject go, HumanDescription humanDescription);
        [FreeFunction("AvatarBuilderBindings::BuildGenericAvatar")]
        public static Avatar BuildGenericAvatar([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] string rootMotionTransformName);
    }
}

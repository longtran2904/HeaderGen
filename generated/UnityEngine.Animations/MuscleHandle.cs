#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/MuscleHandle.h")]
    [NativeHeader("Modules/Animation/Animator.h")]
    public struct MuscleHandle
    {

        public MuscleHandle(BodyDof bodyDof);
        public MuscleHandle(HeadDof headDof);
        public MuscleHandle(HumanPartDof partDof, LegDof legDof);
        public MuscleHandle(HumanPartDof partDof, ArmDof armDof);
        public MuscleHandle(HumanPartDof partDof, FingerDof fingerDof);

        public HumanPartDof humanPartDof { get; }
        public int dof { get; }
        public string name { get; }
        public static int muscleHandleCount { get; }

        public static void GetMuscleHandles([NotNull("ArgumentNullException")] out MuscleHandle[] muscleHandles);
    }
}

#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/HumanTrait.h")]
    public class HumanTrait
    {

        public HumanTrait();

        public static int MuscleCount { get; }
        public static string[] MuscleName { get; }
        public static int BoneCount { get; }
        public static string[] BoneName { get; }
        public static int RequiredBoneCount { get; }

        public static int MuscleFromBone(int i, int dofIndex);
        public static int BoneFromMuscle(int i);
        public static bool RequiredBone(int i);
        public static float GetMuscleDefaultMin(int i);
        public static float GetMuscleDefaultMax(int i);
        public static float GetBoneDefaultHierarchyMass(int i);
        public static int GetParentBone(int i);
    }
}

#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
    [NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
    [RequiredByNativeCode]
    public struct AnimationHumanStream
    {

        public bool isValid { get; }
        public float humanScale { get; }
        public float leftFootHeight { get; }
        public float rightFootHeight { get; }
        public Vector3 bodyLocalPosition { get; set; }
        public Quaternion bodyLocalRotation { get; set; }
        public Vector3 bodyPosition { get; set; }
        public Quaternion bodyRotation { get; set; }
        public Vector3 leftFootVelocity { get; }
        public Vector3 rightFootVelocity { get; }

        public float GetMuscle(MuscleHandle muscle);
        public void SetMuscle(MuscleHandle muscle, float value);
        public void ResetToStancePose();
        public Vector3 GetGoalPositionFromPose(AvatarIKGoal index);
        public Quaternion GetGoalRotationFromPose(AvatarIKGoal index);
        public Vector3 GetGoalLocalPosition(AvatarIKGoal index);
        public void SetGoalLocalPosition(AvatarIKGoal index, Vector3 pos);
        public Quaternion GetGoalLocalRotation(AvatarIKGoal index);
        public void SetGoalLocalRotation(AvatarIKGoal index, Quaternion rot);
        public Vector3 GetGoalPosition(AvatarIKGoal index);
        public void SetGoalPosition(AvatarIKGoal index, Vector3 pos);
        public Quaternion GetGoalRotation(AvatarIKGoal index);
        public void SetGoalRotation(AvatarIKGoal index, Quaternion rot);
        public void SetGoalWeightPosition(AvatarIKGoal index, float value);
        public void SetGoalWeightRotation(AvatarIKGoal index, float value);
        public float GetGoalWeightPosition(AvatarIKGoal index);
        public float GetGoalWeightRotation(AvatarIKGoal index);
        public Vector3 GetHintPosition(AvatarIKHint index);
        public void SetHintPosition(AvatarIKHint index, Vector3 pos);
        public void SetHintWeightPosition(AvatarIKHint index, float value);
        public float GetHintWeightPosition(AvatarIKHint index);
        public void SetLookAtPosition(Vector3 lookAtPosition);
        public void SetLookAtClampWeight(float weight);
        public void SetLookAtBodyWeight(float weight);
        public void SetLookAtHeadWeight(float weight);
        public void SetLookAtEyesWeight(float weight);
        public void SolveIK();
    }
}

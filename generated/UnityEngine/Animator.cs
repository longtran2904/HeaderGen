#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/Animator.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
    [UsedByNativeCode]
    public class Animator : Behaviour
    {
        public Animator();

        public bool isOptimizable { get; }
        public bool isHuman { get; }
        public bool hasRootMotion { get; }
        public float humanScale { get; }
        public bool isInitialized { get; }
        public Vector3 deltaPosition { get; }
        public Quaternion deltaRotation { get; }
        public Vector3 velocity { get; }
        public Vector3 angularVelocity { get; }
        public Vector3 rootPosition { get; set; }
        public Quaternion rootRotation { get; set; }
        public bool applyRootMotion { get; set; }
        [Obsolete("Animator.linearVelocityBlending is no longer used and has been deprecated.")]
        public bool linearVelocityBlending { get; set; }
        [Obsolete("Animator.animatePhysics has been deprecated. Use Animator.updateMode instead.")]
        public bool animatePhysics { get; set; }
        public AnimatorUpdateMode updateMode { get; set; }
        public bool hasTransformHierarchy { get; }
        public float gravityWeight { get; }
        public Vector3 bodyPosition { get; set; }
        public Quaternion bodyRotation { get; set; }
        public bool stabilizeFeet { get; set; }
        public int layerCount { get; }
        public AnimatorControllerParameter[] parameters { get; }
        public int parameterCount { get; }
        public float feetPivotActive { get; set; }
        public float pivotWeight { get; }
        public Vector3 pivotPosition { get; }
        public bool isMatchingTarget { get; }
        public float speed { get; set; }
        public Vector3 targetPosition { get; }
        public Quaternion targetRotation { get; }
        public AnimatorCullingMode cullingMode { get; set; }
        public float playbackTime { get; set; }
        public float recorderStartTime { get; set; }
        public float recorderStopTime { get; set; }
        public AnimatorRecorderMode recorderMode { get; }
        public RuntimeAnimatorController runtimeAnimatorController { get; set; }
        public bool hasBoundPlayables { get; }
        public Avatar avatar { get; set; }
        public PlayableGraph playableGraph { get; }
        public bool layersAffectMassCenter { get; set; }
        public float leftFeetBottomHeight { get; }
        public float rightFeetBottomHeight { get; }
        public bool logWarnings { get; set; }
        public bool fireEvents { get; set; }
        [Obsolete("keepAnimatorControllerStateOnDisable is deprecated, use keepAnimatorStateOnDisable instead. (UnityUpgradable) -> keepAnimatorStateOnDisable", False)]
        public bool keepAnimatorControllerStateOnDisable { get; set; }
        public bool keepAnimatorStateOnDisable { get; set; }
        public bool writeDefaultValuesOnDisable { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GetCurrentAnimationClipState is obsolete. Use GetCurrentAnimatorClipInfo instead (UnityUpgradable) -> GetCurrentAnimatorClipInfo(*)", True)]
        public AnimationInfo[] GetCurrentAnimationClipState(int layerIndex);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GetNextAnimationClipState is obsolete. Use GetNextAnimatorClipInfo instead (UnityUpgradable) -> GetNextAnimatorClipInfo(*)", True)]
        public AnimationInfo[] GetNextAnimationClipState(int layerIndex);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Stop is obsolete. Use Animator.enabled = false instead", True)]
        public void Stop();
        public float GetFloat(string name);
        public float GetFloat(int id);
        public void SetFloat(string name, float value);
        public void SetFloat(string name, float value, float dampTime, float deltaTime);
        public void SetFloat(int id, float value);
        public void SetFloat(int id, float value, float dampTime, float deltaTime);
        public bool GetBool(string name);
        public bool GetBool(int id);
        public void SetBool(string name, bool value);
        public void SetBool(int id, bool value);
        public int GetInteger(string name);
        public int GetInteger(int id);
        public void SetInteger(string name, int value);
        public void SetInteger(int id, int value);
        public void SetTrigger(string name);
        public void SetTrigger(int id);
        public void ResetTrigger(string name);
        public void ResetTrigger(int id);
        public bool IsParameterControlledByCurve(string name);
        public bool IsParameterControlledByCurve(int id);
        public Vector3 GetIKPosition(AvatarIKGoal goal);
        public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition);
        public Quaternion GetIKRotation(AvatarIKGoal goal);
        public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation);
        public float GetIKPositionWeight(AvatarIKGoal goal);
        public void SetIKPositionWeight(AvatarIKGoal goal, float value);
        public float GetIKRotationWeight(AvatarIKGoal goal);
        public void SetIKRotationWeight(AvatarIKGoal goal, float value);
        public Vector3 GetIKHintPosition(AvatarIKHint hint);
        public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition);
        public float GetIKHintPositionWeight(AvatarIKHint hint);
        public void SetIKHintPositionWeight(AvatarIKHint hint, float value);
        public void SetLookAtPosition(Vector3 lookAtPosition);
        public void SetLookAtWeight(float weight);
        public void SetLookAtWeight(float weight, float bodyWeight);
        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight);
        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight);
        public void SetLookAtWeight(float weight, [DefaultValue("0.0f")] float bodyWeight, [DefaultValue("1.0f")] float headWeight, [DefaultValue("0.0f")] float eyesWeight, [DefaultValue("0.5f")] float clampWeight);
        public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation);
        public T GetBehaviour<T>() where T : StateMachineBehaviour;
        public T[] GetBehaviours<T>() where T : StateMachineBehaviour;
        public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex);
        public string GetLayerName(int layerIndex);
        public int GetLayerIndex(string layerName);
        public float GetLayerWeight(int layerIndex);
        public void SetLayerWeight(int layerIndex, float weight);
        public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
        public int GetCurrentAnimatorClipInfoCount(int layerIndex);
        public int GetNextAnimatorClipInfoCount(int layerIndex);
        [FreeFunction(Name = "AnimatorBindings::GetCurrentAnimatorClipInfo", HasExplicitThis = True)]
        public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
        [FreeFunction(Name = "AnimatorBindings::GetNextAnimatorClipInfo", HasExplicitThis = True)]
        public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
        public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
        public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
        public bool IsInTransition(int layerIndex);
        public AnimatorControllerParameter GetParameter(int index);
        public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime);
        public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [DefaultValue("1")] float targetNormalizedTime);
        public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [DefaultValue("1")] float targetNormalizedTime, [DefaultValue("true")] bool completeMatch);
        public void InterruptMatchTarget();
        public void InterruptMatchTarget([DefaultValue("true")] bool completeMatch);
        [Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
        public void ForceStateNormalizedTime(float normalizedTime);
        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration);
        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer);
        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime);
        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer);
        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration);
        [FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = True)]
        public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime);
        [FreeFunction(Name = "AnimatorBindings::WriteDefaultValues", HasExplicitThis = True)]
        public void WriteDefaultValues();
        public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        public void CrossFade(string stateName, float normalizedTransitionDuration, int layer);
        public void CrossFade(string stateName, float normalizedTransitionDuration);
        public void CrossFade(string stateName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime);
        [FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
        public void CrossFade(int stateHashName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime);
        public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer);
        public void CrossFade(int stateHashName, float normalizedTransitionDuration);
        public void PlayInFixedTime(string stateName, int layer);
        public void PlayInFixedTime(string stateName);
        public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);
        [FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = True)]
        public void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);
        public void PlayInFixedTime(int stateNameHash, int layer);
        public void PlayInFixedTime(int stateNameHash);
        public void Play(string stateName, int layer);
        public void Play(string stateName);
        public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
        [FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
        public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
        public void Play(int stateNameHash, int layer);
        public void Play(int stateNameHash);
        public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use mask and layers to control subset of transfroms in a skeleton.", True)]
        public bool IsControlled(Transform transform);
        public Transform GetBoneTransform(HumanBodyBones humanBoneId);
        public void StartPlayback();
        public void StopPlayback();
        public void StartRecording(int frameCount);
        public void StopRecording();
        public bool HasState(int layerIndex, int stateID);
        [NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
        public static int StringToHash(string name);
        [NativeMethod("UpdateWithDelta")]
        public void Update(float deltaTime);
        public void Rebind();
        public void ApplyBuiltinRootMotion();
        [Obsolete("GetVector is deprecated.")]
        public Vector3 GetVector(string name);
        [Obsolete("GetVector is deprecated.")]
        public Vector3 GetVector(int id);
        [Obsolete("SetVector is deprecated.")]
        public void SetVector(string name, Vector3 value);
        [Obsolete("SetVector is deprecated.")]
        public void SetVector(int id, Vector3 value);
        [Obsolete("GetQuaternion is deprecated.")]
        public Quaternion GetQuaternion(string name);
        [Obsolete("GetQuaternion is deprecated.")]
        public Quaternion GetQuaternion(int id);
        [Obsolete("SetQuaternion is deprecated.")]
        public void SetQuaternion(string name, Quaternion value);
        [Obsolete("SetQuaternion is deprecated.")]
        public void SetQuaternion(int id, Quaternion value);
    }
}

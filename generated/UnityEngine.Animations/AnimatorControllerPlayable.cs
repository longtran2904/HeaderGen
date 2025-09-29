#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
    [NativeHeader("Modules/Animation/AnimatorInfo.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
    [NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
    [NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
    [RequiredByNativeCode]
    [StaticAccessor("AnimatorControllerPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>, IPlayable
    {

        public static AnimatorControllerPlayable Null { get; }

        public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller);
        public PlayableHandle GetHandle();
        public void SetHandle(PlayableHandle handle);
        public bool Equals(AnimatorControllerPlayable other);
        public float GetFloat(string name);
        public float GetFloat(int id);
        public void SetFloat(string name, float value);
        public void SetFloat(int id, float value);
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
        public int GetLayerCount();
        public string GetLayerName(int layerIndex);
        public int GetLayerIndex(string layerName);
        public float GetLayerWeight(int layerIndex);
        public void SetLayerWeight(int layerIndex, float weight);
        public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
        public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
        public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
        public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
        public int GetCurrentAnimatorClipInfoCount(int layerIndex);
        public int GetNextAnimatorClipInfoCount(int layerIndex);
        public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
        public bool IsInTransition(int layerIndex);
        public int GetParameterCount();
        public AnimatorControllerParameter GetParameter(int index);
        public void CrossFadeInFixedTime(string stateName, float transitionDuration);
        public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer);
        public void CrossFadeInFixedTime(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime);
        public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration);
        public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer);
        public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime);
        public void CrossFade(string stateName, float transitionDuration);
        public void CrossFade(string stateName, float transitionDuration, int layer);
        public void CrossFade(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
        public void CrossFade(int stateNameHash, float transitionDuration);
        public void CrossFade(int stateNameHash, float transitionDuration, int layer);
        public void CrossFade(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
        public void PlayInFixedTime(string stateName);
        public void PlayInFixedTime(string stateName, int layer);
        public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);
        public void PlayInFixedTime(int stateNameHash);
        public void PlayInFixedTime(int stateNameHash, int layer);
        public void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);
        public void Play(string stateName);
        public void Play(string stateName, int layer);
        public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
        public void Play(int stateNameHash);
        public void Play(int stateNameHash, int layer);
        public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
        public bool HasState(int layerIndex, int stateID);

        public static implicit operator Playable(AnimatorControllerPlayable playable);
        public static explicit operator AnimatorControllerPlayable(Playable playable);
    }
}

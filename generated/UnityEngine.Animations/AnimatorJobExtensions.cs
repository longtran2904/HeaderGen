#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimatorJobExtensions.bindings.h")]
    [NativeHeader("Modules/Animation/Animator.h")]
    [NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
    [NativeHeader("Modules/Animation/Director/AnimationStream.h")]
    [NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
    [StaticAccessor("AnimatorJobExtensionsBindings", StaticAccessorType.DoubleColon)]
    public static class AnimatorJobExtensions
    {
        public static void AddJobDependency(this Animator animator, JobHandle jobHandle);
        public static TransformStreamHandle BindStreamTransform(this Animator animator, Transform transform);
        public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, Type type, string property);
        public static PropertyStreamHandle BindCustomStreamProperty(this Animator animator, string property, CustomStreamPropertyType type);
        public static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, Type type, string property, [DefaultValue("false")] bool isObjectReference);
        public static TransformSceneHandle BindSceneTransform(this Animator animator, Transform transform);
        public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, Type type, string property);
        public static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, Type type, string property, [DefaultValue("false")] bool isObjectReference);
        public static bool OpenAnimationStream(this Animator animator, ref AnimationStream stream);
        public static void CloseAnimationStream(this Animator animator, ref AnimationStream stream);
        public static void ResolveAllStreamHandles(this Animator animator);
        public static void ResolveAllSceneHandles(this Animator animator);
        public static void UnbindAllStreamHandles(this Animator animator);
        public static void UnbindAllSceneHandles(this Animator animator);
    }
}

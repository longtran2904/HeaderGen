#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Animation/AnimationUtility.bindings.h")]
    public class AnimationUtility
    {

        public static OnCurveWasModified onCurveWasModified;

        public AnimationUtility();

        [Obsolete("GetAnimationClips(Animation) is deprecated. Use GetAnimationClips(GameObject) instead.")]
        public static AnimationClip[] GetAnimationClips(Animation component);
        public static AnimationClip[] GetAnimationClips(GameObject gameObject);
        public static void SetAnimationClips([NotNull("ArgumentNullException")] Animation animation, [Unmarshalled] AnimationClip[] clips);
        public static EditorCurveBinding[] GetAnimatableBindings(GameObject targetObject, GameObject root);
        public static Type GetEditorCurveValueType(GameObject root, EditorCurveBinding binding);
        public static bool GetFloatValue([NotNull("ArgumentNullException")] GameObject root, EditorCurveBinding binding, out float data);
        public static bool GetObjectReferenceValue(GameObject root, EditorCurveBinding binding, out UnityEngine.Object data);
        public static UnityEngine.Object GetAnimatedObject([NotNull("ArgumentNullException")] GameObject root, EditorCurveBinding binding);
        public static Type PropertyModificationToEditorCurveBinding(PropertyModification modification, GameObject gameObject, out EditorCurveBinding binding);
        public static EditorCurveBinding[] GetCurveBindings([NotNull("ArgumentNullException")] AnimationClip clip);
        public static EditorCurveBinding[] GetObjectReferenceCurveBindings([NotNull("ArgumentNullException")] AnimationClip clip);
        public static ObjectReferenceKeyframe[] GetObjectReferenceCurve([NotNull("ArgumentNullException")] AnimationClip clip, EditorCurveBinding binding);
        public static void SetObjectReferenceCurve(AnimationClip clip, EditorCurveBinding binding, [Unmarshalled] ObjectReferenceKeyframe[] keyframes);
        public static void SetObjectReferenceCurves(AnimationClip clip, EditorCurveBinding[] bindings, ObjectReferenceKeyframe[][] keyframes);
        public static AnimationCurve GetEditorCurve([NotNull("ArgumentNullException")] AnimationClip clip, EditorCurveBinding binding);
        public static void SetEditorCurve(AnimationClip clip, EditorCurveBinding binding, AnimationCurve curve);
        public static void SetEditorCurves(AnimationClip clip, EditorCurveBinding[] bindings, AnimationCurve[] curves);
        [NativeThrows]
        [ThreadSafe]
        public static TangentMode GetKeyLeftTangentMode([NotNull("ArgumentNullException")] AnimationCurve curve, int index);
        [NativeThrows]
        [ThreadSafe]
        public static TangentMode GetKeyRightTangentMode([NotNull("ArgumentNullException")] AnimationCurve curve, int index);
        [NativeThrows]
        public static bool GetKeyBroken([NotNull("ArgumentNullException")] AnimationCurve curve, int index);
        [NativeThrows]
        [ThreadSafe]
        public static void SetKeyLeftTangentMode([NotNull("ArgumentNullException")] AnimationCurve curve, int index, TangentMode tangentMode);
        [NativeThrows]
        [ThreadSafe]
        public static void SetKeyRightTangentMode([NotNull("ArgumentNullException")] AnimationCurve curve, int index, TangentMode tangentMode);
        [NativeThrows]
        public static void SetKeyBroken([NotNull("ArgumentNullException")] AnimationCurve curve, int index, bool broken);
        [Obsolete("GetAllCurves is deprecated. Use GetCurveBindings and GetObjectReferenceCurveBindings instead.")]
        public static AnimationClipCurveData[] GetAllCurves(AnimationClip clip);
        [Obsolete("GetAllCurves is deprecated. Use GetCurveBindings and GetObjectReferenceCurveBindings instead.")]
        public static AnimationClipCurveData[] GetAllCurves(AnimationClip clip, [DefaultValue("true")] bool includeCurveData);
        [Obsolete("This overload is deprecated. Use the one with EditorCurveBinding instead.")]
        public static bool GetFloatValue(GameObject root, string relativePath, Type type, string propertyName, out float data);
        [Obsolete("This overload is deprecated. Use the one with EditorCurveBinding instead.")]
        public static void SetEditorCurve(AnimationClip clip, string relativePath, Type type, string propertyName, AnimationCurve curve);
        [Obsolete("This overload is deprecated. Use the one with EditorCurveBinding instead.")]
        public static AnimationCurve GetEditorCurve(AnimationClip clip, string relativePath, Type type, string propertyName);
        public static AnimationEvent[] GetAnimationEvents([NotNull("ArgumentNullException")] AnimationClip clip);
        [NativeThrows]
        public static void SetAnimationEvents([NotNull("ArgumentNullException")] AnimationClip clip, [NotNull("ArgumentNullException")][Unmarshalled] AnimationEvent[] events);
        public static string CalculateTransformPath([NotNull("ArgumentNullException")] Transform targetTransform, Transform root);
        public static AnimationClipSettings GetAnimationClipSettings([NotNull("ArgumentNullException")] AnimationClip clip);
        public static void SetAnimationClipSettings([NotNull("ArgumentNullException")] AnimationClip clip, AnimationClipSettings srcClipInfo);
        public static void SetAdditiveReferencePose(AnimationClip clip, AnimationClip referenceClip, float time);
        public static void ConstrainToPolynomialCurve(AnimationCurve curve);
        [Obsolete("This is not used anymore.  Root motion curves are automatically generated if applyRootMotion is enabled on Animator component.")]
        public static bool GetGenerateMotionCurves(AnimationClip clip);
        [Obsolete("This is not used anymore.  Root motion curves are automatically generated if applyRootMotion is enabled on Animator component.")]
        public static void SetGenerateMotionCurves(AnimationClip clip, bool value);
        [Obsolete("Use AnimationMode.InAnimationMode instead.")]
        public static bool InAnimationMode();
        [Obsolete("Use AnimationMode.StartAnimationmode instead.")]
        public static void StartAnimationMode(UnityEngine.Object[] objects);
        [Obsolete("Use AnimationMode.StopAnimationMode instead.")]
        public static void StopAnimationMode();
        [Obsolete("SetAnimationType is no longer supported.")]
        public static void SetAnimationType(AnimationClip clip, ModelImporterAnimationType type);
        public enum CurveModifiedType
        {

            CurveDeleted = 0,
            CurveModified = 1,
            ClipModified = 2
        }
        public enum TangentMode
        {

            Free = 0,
            Auto = 1,
            Linear = 2,
            Constant = 3,
            ClampedAuto = 4
        }
        public delegate void OnCurveWasModified(AnimationClip clip, EditorCurveBinding binding, CurveModifiedType type);
    }
}

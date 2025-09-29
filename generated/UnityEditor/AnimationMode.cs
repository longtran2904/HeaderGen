#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Prefabs/PropertyModification.h")]
    [NativeHeader("Editor/Src/Animation/EditorCurveBinding.bindings.h")]
    [NativeHeader("Editor/Src/Animation/AnimationMode.bindings.h")]
    public class AnimationMode
    {

        public AnimationMode();

        public static Color animatedPropertyColor { get; }
        public static Color recordedPropertyColor { get; }
        public static Color candidatePropertyColor { get; }

        public static bool IsPropertyAnimated(UnityEngine.Object target, string propertyPath);
        public static void StopAnimationMode();
        public static void StopAnimationMode(AnimationModeDriver driver);
        public static bool InAnimationMode();
        public static bool InAnimationMode(AnimationModeDriver driver);
        public static void StartAnimationMode();
        public static void StartAnimationMode(AnimationModeDriver driver);
        [NativeThrows]
        public static void BeginSampling();
        [NativeThrows]
        public static void EndSampling();
        [NativeThrows]
        public static void SampleAnimationClip([NotNull("ArgumentNullException")] GameObject gameObject, [NotNull("ArgumentNullException")] AnimationClip clip, float time);
        [NativeThrows]
        public static void SamplePlayableGraph(PlayableGraph graph, int index, float time);
        [NativeThrows]
        public static void AddPropertyModification(EditorCurveBinding binding, PropertyModification modification, bool keepPrefabOverride);
        [NativeThrows]
        public static void AddEditorCurveBinding([NotNull("ArgumentNullException")] GameObject gameObject, EditorCurveBinding binding);
    }
}

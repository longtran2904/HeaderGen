#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Animations
{
    [NativeHeader("Editor/Src/Animation/EditorCurveBinding.bindings.h")]
    [NativeHeader("Editor/Src/Animation/GameObjectRecorder.h")]
    [NativeHeader("Modules/Animation/AnimationClip.h")]
    [NativeType]
    public class GameObjectRecorder : UnityEngine.Object
    {
        public GameObjectRecorder(GameObject root);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The GameObjectRecorder constructor now takes a root GameObject", True)]
        public GameObjectRecorder();

        public GameObject root { get; }
        public float currentTime { get; }
        public bool isRecording { get; }

        public void BindComponentsOfType<T>(GameObject target, bool recursive) where T : Component;
        public void BindComponentsOfType(GameObject target, Type componentType, bool recursive);
        public void Bind(EditorCurveBinding binding);
        public void BindAll(GameObject target, bool recursive);
        public void BindComponent([NotNull("ArgumentNullException")] Component component);
        public EditorCurveBinding[] GetBindings();
        public void TakeSnapshot(float dt);
        public void SaveToClip(AnimationClip clip);
        public void SaveToClip(AnimationClip clip, float fps);
        public void SaveToClip(AnimationClip clip, float fps, CurveFilterOptions filterOptions);
        public void ResetRecording();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("BindComponent() using a System::Type is obsolete, use BindComponentsOfType() instead (UnityUpgradable) -> BindComponentsOfType(*)", True)]
        public void BindComponent(GameObject target, Type componentType, bool recursive);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("\"BindComponent<T>() where T : Component\" is obsolete, use BindComponentsOfType<T>() instead (UnityUpgradable) -> BindComponentsOfType<T>(*)", True)]
        public void BindComponent<T>(GameObject target, bool recursive) where T : Component;
    }
}

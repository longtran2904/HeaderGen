#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

namespace UnityEditorInternal
{
    [InitializeOnLoad]
    public class EditMode
    {
        public static OnEditModeStopFunc onEditModeEndDelegate;
        public static OnEditModeStartFunc onEditModeStartDelegate;

        public EditMode();

        public static SceneViewEditMode editMode { get; }

        public static bool IsOwner(Editor editor);
        public static void OnSelectionChange();
        public static void QuitEditMode();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Obsolete msg (UnityUpgradable) -> UnityEditor.EditorTools.ToolManager.RestorePreviousTool()")]
        public static void ResetToolToPrevious();
        [Obsolete("Use signature passing Func<Bounds> rather than Bounds.")]
        public static void DoEditModeInspectorModeButton(SceneViewEditMode mode, string label, GUIContent icon, Bounds bounds, Editor caller);
        public static void DoEditModeInspectorModeButton(SceneViewEditMode mode, string label, GUIContent icon, Func<Bounds> getBoundsOfTargets, Editor caller);
        [Obsolete("Use signature passing Func<Bounds> rather than Bounds.")]
        public static void DoInspectorToolbar(SceneViewEditMode[] modes, GUIContent[] guiContents, Bounds bounds, Editor caller);
        public static void DoInspectorToolbar(SceneViewEditMode[] modes, GUIContent[] guiContents, Func<Bounds> getBoundsOfTargets, Editor caller);
        public static void ChangeEditMode(SceneViewEditMode mode, Bounds bounds, Editor caller);

        public delegate void OnEditModeStopFunc(Editor editor);
        public delegate void OnEditModeStartFunc(Editor editor, SceneViewEditMode mode);
        public enum SceneViewEditMode
        {
            None = 0,
            Collider = 1,
            ClothConstraints = 2,
            ClothSelfAndInterCollisionParticles = 3,
            ReflectionProbeBox = 4,
            ReflectionProbeOrigin = 5,
            LightProbeProxyVolumeBox = 6,
            LightProbeProxyVolumeOrigin = 7,
            LightProbeGroup = 8,
            JointAngularLimits = 9,
            GridPainting = 10,
            GridPicking = 11,
            GridEraser = 12,
            GridFloodFill = 13,
            GridBox = 14,
            GridSelect = 15,
            GridMove = 16,
            ParticleSystemCollisionModulePlanesMove = 17,
            ParticleSystemCollisionModulePlanesRotate = 18,
            LineRendererEdit = 19,
            LineRendererCreate = 20,
            ParticleSystemShapeModuleGizmo = 21,
            ParticleSystemShapeModulePosition = 22,
            ParticleSystemShapeModuleRotation = 23,
            ParticleSystemShapeModuleScale = 24
        }
    }
}

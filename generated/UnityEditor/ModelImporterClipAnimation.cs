#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeHeader("Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.bindings.h")]
    [NativeType(IntermediateScriptingStructName = "MonoClipAnimationInfo", CodegenOptions = CodegenOptions.Custom)]
    [UsedByNativeCode]
    public sealed class ModelImporterClipAnimation
    {
        public ModelImporterClipAnimation();

        public string takeName { get; set; }
        public string name { get; set; }
        public float firstFrame { get; set; }
        public float lastFrame { get; set; }
        public WrapMode wrapMode { get; set; }
        public bool loop { get; set; }
        public float rotationOffset { get; set; }
        public float heightOffset { get; set; }
        public float cycleOffset { get; set; }
        public bool loopTime { get; set; }
        public bool loopPose { get; set; }
        public bool lockRootRotation { get; set; }
        public bool lockRootHeightY { get; set; }
        public bool lockRootPositionXZ { get; set; }
        public bool keepOriginalOrientation { get; set; }
        public bool keepOriginalPositionY { get; set; }
        public bool keepOriginalPositionXZ { get; set; }
        public bool heightFromFeet { get; set; }
        public bool mirror { get; set; }
        public ClipAnimationMaskType maskType { get; set; }
        public AvatarMask maskSource { get; set; }
        public AnimationEvent[] events { get; set; }
        public ClipAnimationInfoCurve[] curves { get; set; }
        public bool maskNeedsUpdating { get; }
        public float additiveReferencePoseFrame { get; set; }
        public bool hasAdditiveReferencePose { get; set; }

        public void ConfigureMaskFromClip(ref AvatarMask mask);
        public void ConfigureClipFromMask(AvatarMask mask);
        public override bool Equals(object o);
        public override int GetHashCode();
    }
}

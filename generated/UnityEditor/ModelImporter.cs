#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
    [NativeHeader("Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.bindings.h")]
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.h")]
    public class ModelImporter : AssetImporter
    {

        public ModelImporter();

        [Obsolete("generateMaterials has been  removed. Use materialImportMode, materialName and materialSearch instead.", True)]
        public ModelImporterGenerateMaterials generateMaterials { get; }
        [Obsolete("importMaterials has been  removed. Use materialImportMode instead.", True)]
        public bool importMaterials { get; }
        public ModelImporterMaterialName materialName { get; set; }
        public ModelImporterMaterialSearch materialSearch { get; set; }
        public ModelImporterMaterialLocation materialLocation { get; set; }
        public float globalScale { get; set; }
        public bool isUseFileUnitsSupported { get; }
        public bool importVisibility { get; set; }
        public bool useFileUnits { get; set; }
        public float fileScale { get; }
        public bool useFileScale { get; set; }
        [Obsolete("Use useFileScale instead")]
        public bool isFileScaleUsed { get; }
        public bool importBlendShapes { get; set; }
        public bool importCameras { get; set; }
        public bool importLights { get; set; }
        public bool addCollider { get; set; }
        public float normalSmoothingAngle { get; set; }
        [Obsolete("Please use tangentImportMode instead")]
        public bool splitTangentsAcrossSeams { get; set; }
        public bool swapUVChannels { get; set; }
        public bool weldVertices { get; set; }
        public bool bakeAxisConversion { get; set; }
        public bool optimizeBones { get; set; }
        public bool keepQuads { get; set; }
        public ModelImporterIndexFormat indexFormat { get; set; }
        public bool preserveHierarchy { get; set; }
        public bool generateSecondaryUV { get; set; }
        public float secondaryUVAngleDistortion { get; set; }
        public float secondaryUVAreaDistortion { get; set; }
        public float secondaryUVHardAngle { get; set; }
        public ModelImporterSecondaryUVMarginMethod secondaryUVMarginMethod { get; set; }
        public float secondaryUVPackMargin { get; set; }
        public float secondaryUVMinLightmapResolution { get; set; }
        public float secondaryUVMinObjectScale { get; set; }
        public ModelImporterGenerateAnimations generateAnimations { get; set; }
        public TakeInfo[] importedTakeInfos { get; }
        public string[] transformPaths { get; }
        public string[] referencedClips { get; }
        public bool isReadable { get; set; }
        public MeshOptimizationFlags meshOptimizationFlags { get; set; }
        public bool optimizeMeshPolygons { get; set; }
        public bool optimizeMeshVertices { get; set; }
        [Obsolete("optimizeMesh is deprecated. Use optimizeMeshPolygons and/or optimizeMeshVertices instead.  Note that optimizeMesh false equates to optimizeMeshPolygons true and optimizeMeshVertices false while optimizeMesh true equates to both true")]
        public bool optimizeMesh { get; set; }
        public ModelImporterSkinWeights skinWeights { get; set; }
        public int maxBonesPerVertex { get; set; }
        public float minBoneWeight { get; set; }
        [Obsolete("normalImportMode is deprecated. Use importNormals instead")]
        public ModelImporterTangentSpaceMode normalImportMode { get; set; }
        [Obsolete("tangentImportMode is deprecated. Use importTangents instead")]
        public ModelImporterTangentSpaceMode tangentImportMode { get; set; }
        public ModelImporterNormals importNormals { get; set; }
        public ModelImporterNormalSmoothingSource normalSmoothingSource { get; set; }
        public ModelImporterNormals importBlendShapeNormals { get; set; }
        public ModelImporterNormalCalculationMode normalCalculationMode { get; set; }
        public ModelImporterTangents importTangents { get; set; }
        public bool bakeIK { get; set; }
        public bool isBakeIKSupported { get; }
        [Obsolete("use resampleCurves instead.")]
        public bool resampleRotations { get; set; }
        public bool resampleCurves { get; set; }
        public bool isTangentImportSupported { get; }
        public bool removeConstantScaleCurves { get; set; }
        public bool strictVertexDataChecks { get; set; }
        public ModelImporterMeshCompression meshCompression { get; set; }
        public bool importAnimation { get; set; }
        public bool optimizeGameObjects { get; set; }
        public string[] extraExposedTransformPaths { get; set; }
        public string[] extraUserProperties { get; set; }
        public ModelImporterAnimationCompression animationCompression { get; set; }
        public bool importAnimatedCustomProperties { get; set; }
        public bool importConstraints { get; set; }
        public float animationRotationError { get; set; }
        public float animationPositionError { get; set; }
        public float animationScaleError { get; set; }
        public WrapMode animationWrapMode { get; set; }
        public ModelImporterAnimationType animationType { get; set; }
        public ModelImporterHumanoidOversampling humanoidOversampling { get; set; }
        public string motionNodeName { get; set; }
        public ModelImporterAvatarSetup avatarSetup { get; set; }
        public Avatar sourceAvatar { get; set; }
        public HumanDescription humanDescription { get; set; }
        [Obsolete("splitAnimations has been deprecated please use clipAnimations instead.", True)]
        public bool splitAnimations { get; set; }
        public ModelImporterClipAnimation[] clipAnimations { get; set; }
        public ModelImporterClipAnimation[] defaultClipAnimations { get; }
        public bool useSRGBMaterialColor { get; set; }
        public bool sortHierarchyByName { get; set; }
        public ModelImporterMaterialImportMode materialImportMode { get; set; }
        public bool autoGenerateAvatarMappingIfUnspecified { get; set; }

        public void CreateDefaultMaskForClip(ModelImporterClipAnimation clip);
        public bool ExtractTextures(string folderPath);
        public bool SearchAndRemapMaterials(ModelImporterMaterialName nameOption, ModelImporterMaterialSearch searchOption);
    }
}

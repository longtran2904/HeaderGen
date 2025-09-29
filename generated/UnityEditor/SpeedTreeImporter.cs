#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/AssetPipeline/SpeedTreeImporter.h")]
    [NativeHeader("Runtime/Camera/ReflectionProbeTypes.h")]
    [NativeHeader("Editor/Src/AssetPipeline/SpeedTreeImporter.bindings.h")]
    public class SpeedTreeImporter : AssetImporter
    {

        public static readonly string[] windQualityNames;

        public SpeedTreeImporter();

        public bool hasImported { get; }
        public string materialFolderPath { get; }
        public MaterialLocation materialLocation { get; set; }
        public bool isV8 { get; }
        public Shader defaultShader { get; }
        public Shader defaultBillboardShader { get; }
        public float scaleFactor { get; set; }
        public Color mainColor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("specColor is no longer used and has been deprecated.", True)]
        public Color specColor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("shininess is no longer used and has been deprecated.", True)]
        public float shininess { get; set; }
        public Color hueVariation { get; set; }
        public float alphaTestRef { get; set; }
        public bool hasBillboard { get; }
        public bool enableSmoothLODTransition { get; set; }
        public bool animateCrossFading { get; set; }
        public float billboardTransitionCrossFadeWidth { get; set; }
        public float fadeOutWidth { get; set; }
        public float[] LODHeights { get; set; }
        public bool[] castShadows { get; set; }
        public bool[] receiveShadows { get; set; }
        public bool[] useLightProbes { get; set; }
        public ReflectionProbeUsage[] reflectionProbeUsages { get; set; }
        public bool[] enableBump { get; set; }
        public bool[] enableHue { get; set; }
        public bool[] enableSubsurface { get; set; }
        public int bestWindQuality { get; }
        public int[] windQualities { get; set; }

        public void GenerateMaterials();
        public bool SearchAndRemapMaterials(string materialFolderPath);
        public enum MaterialLocation
        {

            External = 0,
            InPrefab = 1
        }
    }
}

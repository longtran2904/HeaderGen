#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    public sealed class LensFlareCommonSRP
    {
        public static int maxLensFlareWithOcclusion;
        public static int maxLensFlareWithOcclusionTemporalSample;
        public static int mergeNeeded;
        public static RTHandle occlusionRT;

        public static LensFlareCommonSRP Instance { get; }

        public static void Initialize();
        public static void Dispose();
        public List<LensFlareComponentSRP> GetData();
        public bool IsEmpty();
        public void AddData(LensFlareComponentSRP newData);
        public static float ShapeAttenuationPointLight();
        public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo);
        public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01);
        public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo);
        public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo);
        public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam);
        public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo);
        public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo);
        public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate);
        public static void ComputeOcclusion(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4);
        public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, LensFlareCommonSRP lensFlares, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView);
        public void RemoveData(LensFlareComponentSRP data);
    }
}

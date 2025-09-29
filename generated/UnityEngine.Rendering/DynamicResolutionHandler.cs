#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering
{
    public class DynamicResolutionHandler
    {
        public DynamicResUpscaleFilter filter { get; }
        public Vector2Int finalViewport { get; set; }
        public bool runUpscalerFilterOnFullResolution { get; set; }
        public UpsamplerScheduleType upsamplerSchedule { get; set; }
        public static DynamicResolutionHandler instance { get; }

        public Vector2 GetResolvedScale();
        public float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = False);
        public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor);
        public static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor);
        public static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot);
        public static void ClearSelectedCamera();
        public static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter);
        public void SetCurrentCameraRequest(bool cameraRequest);
        public static void UpdateAndUseCamera(Camera camera, GlobalDynamicResolutionSettings? settings = null, Action OnResolutionChange = null);
        public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null);
        public bool SoftwareDynamicResIsEnabled();
        public bool HardwareDynamicResIsEnabled();
        public bool RequestsHardwareDynamicResolution();
        public bool DynamicResolutionEnabled();
        public void ForceSoftwareFallback();
        public Vector2Int GetScaledSize(Vector2Int size);
        public Vector2Int ApplyScalesOnSize(Vector2Int size);
        public float GetCurrentScale();
        public Vector2Int GetLastScaledSize();
        public float GetLowResMultiplier(float targetLowRes);

        public enum UpsamplerScheduleType
        {
            BeforePost = 0,
            AfterPost = 1
        }
    }
}

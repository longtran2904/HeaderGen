#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public struct GlobalDynamicResolutionSettings
    {
        public bool enabled;
        public bool useMipBias;
        public bool enableDLSS;
        public uint DLSSPerfQualitySetting;
        public bool DLSSUseOptimalSettings;
        [Range(0, 1)]
        public float DLSSSharpness;
        public float maxPercentage;
        public float minPercentage;
        public DynamicResolutionType dynResType;
        public DynamicResUpscaleFilter upsampleFilter;
        public bool forceResolution;
        public float forcedPercentage;
        public float lowResTransparencyMinimumThreshold;
        public float rayTracingHalfResThreshold;

        public static GlobalDynamicResolutionSettings NewDefault();
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Input/TimeManager.h")]
    [StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
    public class Time
    {
        public Time();

        [NativeProperty("CurTime")]
        public static float time { get; }
        [NativeProperty("CurTime")]
        public static double timeAsDouble { get; }
        [NativeProperty("TimeSinceSceneLoad")]
        public static float timeSinceLevelLoad { get; }
        [NativeProperty("TimeSinceSceneLoad")]
        public static double timeSinceLevelLoadAsDouble { get; }
        public static float deltaTime { get; }
        public static float fixedTime { get; }
        [NativeProperty("FixedTime")]
        public static double fixedTimeAsDouble { get; }
        public static float unscaledTime { get; }
        [NativeProperty("UnscaledTime")]
        public static double unscaledTimeAsDouble { get; }
        public static float fixedUnscaledTime { get; }
        [NativeProperty("FixedUnscaledTime")]
        public static double fixedUnscaledTimeAsDouble { get; }
        public static float unscaledDeltaTime { get; }
        public static float fixedUnscaledDeltaTime { get; }
        public static float fixedDeltaTime { get; set; }
        public static float maximumDeltaTime { get; set; }
        public static float smoothDeltaTime { get; }
        public static float maximumParticleDeltaTime { get; set; }
        public static float timeScale { get; set; }
        public static int frameCount { get; }
        [NativeProperty("RenderFrameCount")]
        public static int renderedFrameCount { get; }
        [NativeProperty("Realtime")]
        public static float realtimeSinceStartup { get; }
        [NativeProperty("Realtime")]
        public static double realtimeSinceStartupAsDouble { get; }
        public static float captureDeltaTime { get; set; }
        public static int captureFramerate { get; set; }
        public static bool inFixedTimeStep { get; }
    }
}

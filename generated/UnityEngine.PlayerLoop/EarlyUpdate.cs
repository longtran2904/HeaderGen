#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.PlayerLoop
{
    [MovedFrom("UnityEngine.Experimental.PlayerLoop")]
    [RequiredByNativeCode]
    public struct EarlyUpdate
    {
        [RequiredByNativeCode]
        public struct PollPlayerConnection
        {
        }
        [Obsolete("ProfilerStartFrame player loop component has been moved to the Initialization category. (UnityUpgradable) -> UnityEngine.PlayerLoop.Initialization/ProfilerStartFrame", True)]
        public struct ProfilerStartFrame
        {
        }
        [RequiredByNativeCode]
        public struct PollHtcsPlayerConnection
        {
        }
        [RequiredByNativeCode]
        public struct GpuTimestamp
        {
        }
        [RequiredByNativeCode]
        public struct AnalyticsCoreStatsUpdate
        {
        }
        [RequiredByNativeCode]
        public struct UnityWebRequestUpdate
        {
        }
        [RequiredByNativeCode]
        public struct UpdateStreamingManager
        {
        }
        [RequiredByNativeCode]
        public struct ExecuteMainThreadJobs
        {
        }
        [RequiredByNativeCode]
        public struct ProcessMouseInWindow
        {
        }
        [RequiredByNativeCode]
        public struct ClearIntermediateRenderers
        {
        }
        [RequiredByNativeCode]
        public struct ClearLines
        {
        }
        [RequiredByNativeCode]
        public struct PresentBeforeUpdate
        {
        }
        [RequiredByNativeCode]
        public struct ResetFrameStatsAfterPresent
        {
        }
        [RequiredByNativeCode]
        public struct UpdateAsyncReadbackManager
        {
        }
        [RequiredByNativeCode]
        public struct UpdateTextureStreamingManager
        {
        }
        [RequiredByNativeCode]
        public struct UpdatePreloading
        {
        }
        [RequiredByNativeCode]
        public struct RendererNotifyInvisible
        {
        }
        [RequiredByNativeCode]
        public struct PlayerCleanupCachedData
        {
        }
        [RequiredByNativeCode]
        public struct UpdateMainGameViewRect
        {
        }
        [RequiredByNativeCode]
        public struct UpdateCanvasRectTransform
        {
        }
        [RequiredByNativeCode]
        public struct UpdateInputManager
        {
        }
        [RequiredByNativeCode]
        public struct ProcessRemoteInput
        {
        }
        [RequiredByNativeCode]
        public struct XRUpdate
        {
        }
        [RequiredByNativeCode]
        public struct ScriptRunDelayedStartupFrame
        {
        }
        [RequiredByNativeCode]
        public struct UpdateKinect
        {
        }
        [RequiredByNativeCode]
        public struct DeliverIosPlatformEvents
        {
        }
        [RequiredByNativeCode]
        public struct DispatchEventQueueEvents
        {
        }
        [RequiredByNativeCode]
        public struct PhysicsResetInterpolatedTransformPosition
        {
        }
        [RequiredByNativeCode]
        public struct SpriteAtlasManagerUpdate
        {
        }
        [Obsolete("TangoUpdate has been deprecated. Use ARCoreUpdate instead (UnityUpgradable) -> UnityEngine.PlayerLoop.EarlyUpdate/ARCoreUpdate", False)]
        [RequiredByNativeCode]
        public struct TangoUpdate
        {
        }
        [RequiredByNativeCode]
        public struct ARCoreUpdate
        {
        }
        [RequiredByNativeCode]
        public struct PerformanceAnalyticsUpdate
        {
        }
    }
}

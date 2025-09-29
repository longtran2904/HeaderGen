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
    public struct Initialization
    {
        [RequiredByNativeCode]
        public struct ProfilerStartFrame
        {
        }
        [Obsolete("PlayerUpdateTime player loop component has been moved to its own category called TimeUpdate. (UnityUpgradable) -> UnityEngine.PlayerLoop.TimeUpdate/WaitForLastPresentationAndUpdateTime", True)]
        public struct PlayerUpdateTime
        {
        }
        [RequiredByNativeCode]
        public struct UpdateCameraMotionVectors
        {
        }
        [RequiredByNativeCode]
        public struct DirectorSampleTime
        {
        }
        [RequiredByNativeCode]
        public struct AsyncUploadTimeSlicedUpdate
        {
        }
        [RequiredByNativeCode]
        public struct SynchronizeState
        {
        }
        [RequiredByNativeCode]
        public struct SynchronizeInputs
        {
        }
        [RequiredByNativeCode]
        public struct XREarlyUpdate
        {
        }
    }
}

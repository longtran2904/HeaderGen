#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_VR")]
    [NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
    [RequiredByNativeCode]
    [StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType.Dot)]
    public static class InputTracking
    {
        [NativeConditional("ENABLE_VR")]
        [Obsolete("This API is obsolete, and should no longer be used. Please use the TrackedPoseDriver in the Legacy Input Helpers package for controlling a camera in XR.")]
        public static bool disablePositionalTracking { get; set; }

        public static event Action<XRNodeState> trackingAcquired;
        public static event Action<XRNodeState> trackingLost;
        public static event Action<XRNodeState> nodeAdded;
        public static event Action<XRNodeState> nodeRemoved;

        [NativeConditional("ENABLE_VR", "Vector3f::zero")]
        [Obsolete("This API is obsolete, and should no longer be used. Please use InputDevice.TryGetFeatureValue with the CommonUsages.devicePosition usage instead.")]
        public static Vector3 GetLocalPosition(XRNode node);
        [NativeConditional("ENABLE_VR", "Quaternionf::identity()")]
        [Obsolete("This API is obsolete, and should no longer be used. Please use InputDevice.TryGetFeatureValue with the CommonUsages.deviceRotation usage instead.")]
        public static Quaternion GetLocalRotation(XRNode node);
        [NativeConditional("ENABLE_VR")]
        [Obsolete("This API is obsolete, and should no longer be used. Please use XRInputSubsystem.TryRecenter() instead.")]
        public static void Recenter();
        [NativeConditional("ENABLE_VR")]
        [Obsolete("This API is obsolete, and should no longer be used. Please use InputDevice.name with the device associated with that tracking data instead.")]
        public static string GetNodeName(ulong uniqueId);
        public static void GetNodeStates(List<XRNodeState> nodeStates);
    }
}

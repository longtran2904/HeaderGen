#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;

namespace UnityEngine.XR
{
    public static class CommonUsages
    {

        public static InputFeatureUsage<bool> isTracked;
        public static InputFeatureUsage<bool> primaryButton;
        public static InputFeatureUsage<bool> primaryTouch;
        public static InputFeatureUsage<bool> secondaryButton;
        public static InputFeatureUsage<bool> secondaryTouch;
        public static InputFeatureUsage<bool> gripButton;
        public static InputFeatureUsage<bool> triggerButton;
        public static InputFeatureUsage<bool> menuButton;
        public static InputFeatureUsage<bool> primary2DAxisClick;
        public static InputFeatureUsage<bool> primary2DAxisTouch;
        public static InputFeatureUsage<bool> secondary2DAxisClick;
        public static InputFeatureUsage<bool> secondary2DAxisTouch;
        public static InputFeatureUsage<bool> userPresence;
        public static InputFeatureUsage<InputTrackingState> trackingState;
        public static InputFeatureUsage<float> batteryLevel;
        public static InputFeatureUsage<float> trigger;
        public static InputFeatureUsage<float> grip;
        public static InputFeatureUsage<Vector2> primary2DAxis;
        public static InputFeatureUsage<Vector2> secondary2DAxis;
        public static InputFeatureUsage<Vector3> devicePosition;
        public static InputFeatureUsage<Vector3> leftEyePosition;
        public static InputFeatureUsage<Vector3> rightEyePosition;
        public static InputFeatureUsage<Vector3> centerEyePosition;
        public static InputFeatureUsage<Vector3> colorCameraPosition;
        public static InputFeatureUsage<Vector3> deviceVelocity;
        public static InputFeatureUsage<Vector3> deviceAngularVelocity;
        public static InputFeatureUsage<Vector3> leftEyeVelocity;
        public static InputFeatureUsage<Vector3> leftEyeAngularVelocity;
        public static InputFeatureUsage<Vector3> rightEyeVelocity;
        public static InputFeatureUsage<Vector3> rightEyeAngularVelocity;
        public static InputFeatureUsage<Vector3> centerEyeVelocity;
        public static InputFeatureUsage<Vector3> centerEyeAngularVelocity;
        public static InputFeatureUsage<Vector3> colorCameraVelocity;
        public static InputFeatureUsage<Vector3> colorCameraAngularVelocity;
        public static InputFeatureUsage<Vector3> deviceAcceleration;
        public static InputFeatureUsage<Vector3> deviceAngularAcceleration;
        public static InputFeatureUsage<Vector3> leftEyeAcceleration;
        public static InputFeatureUsage<Vector3> leftEyeAngularAcceleration;
        public static InputFeatureUsage<Vector3> rightEyeAcceleration;
        public static InputFeatureUsage<Vector3> rightEyeAngularAcceleration;
        public static InputFeatureUsage<Vector3> centerEyeAcceleration;
        public static InputFeatureUsage<Vector3> centerEyeAngularAcceleration;
        public static InputFeatureUsage<Vector3> colorCameraAcceleration;
        public static InputFeatureUsage<Vector3> colorCameraAngularAcceleration;
        public static InputFeatureUsage<Quaternion> deviceRotation;
        public static InputFeatureUsage<Quaternion> leftEyeRotation;
        public static InputFeatureUsage<Quaternion> rightEyeRotation;
        public static InputFeatureUsage<Quaternion> centerEyeRotation;
        public static InputFeatureUsage<Quaternion> colorCameraRotation;
        public static InputFeatureUsage<Hand> handData;
        public static InputFeatureUsage<Eyes> eyesData;
        [Obsolete("CommonUsages.dPad is not used by any XR platform and will be removed.")]
        public static InputFeatureUsage<Vector2> dPad;
        [Obsolete("CommonUsages.indexFinger is not used by any XR platform and will be removed.")]
        public static InputFeatureUsage<float> indexFinger;
        [Obsolete("CommonUsages.MiddleFinger is not used by any XR platform and will be removed.")]
        public static InputFeatureUsage<float> middleFinger;
        [Obsolete("CommonUsages.RingFinger is not used by any XR platform and will be removed.")]
        public static InputFeatureUsage<float> ringFinger;
        [Obsolete("CommonUsages.PinkyFinger is not used by any XR platform and will be removed.")]
        public static InputFeatureUsage<float> pinkyFinger;
        [Obsolete("CommonUsages.thumbrest is Oculus only, and is being moved to their package. Please use OculusUsages.thumbrest. These will still function until removed.")]
        public static InputFeatureUsage<bool> thumbrest;
        [Obsolete("CommonUsages.indexTouch is Oculus only, and is being moved to their package.  Please use OculusUsages.indexTouch. These will still function until removed.")]
        public static InputFeatureUsage<float> indexTouch;
        [Obsolete("CommonUsages.thumbTouch is Oculus only, and is being moved to their package.  Please use OculusUsages.thumbTouch. These will still function until removed.")]
        public static InputFeatureUsage<float> thumbTouch;
    }
}

#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_XR")]
    [NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
    [UsedByNativeCode]
    public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
    {

        public XRInputSubsystem();

        public event Action<XRInputSubsystem> trackingOriginUpdated;
        public event Action<XRInputSubsystem> boundaryChanged;

        public bool TryRecenter();
        public bool TryGetInputDevices(List<InputDevice> devices);
        public bool TrySetTrackingOriginMode(TrackingOriginModeFlags origin);
        public TrackingOriginModeFlags GetTrackingOriginMode();
        public TrackingOriginModeFlags GetSupportedTrackingOriginModes();
        public bool TryGetBoundaryPoints(List<Vector3> boundaryPoints);
    }
}

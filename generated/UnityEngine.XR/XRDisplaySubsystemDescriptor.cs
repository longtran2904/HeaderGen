#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystemDescriptor.h")]
    [UsedByNativeCode]
    public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem>
    {
        public XRDisplaySubsystemDescriptor();

        [NativeConditional("ENABLE_XR")]
        public bool disablesLegacyVr { get; }
        [NativeConditional("ENABLE_XR")]
        public bool enableBackBufferMSAA { get; }

        [NativeConditional("ENABLE_XR")]
        [NativeMethod("TryGetAvailableMirrorModeCount")]
        public int GetAvailableMirrorBlitModeCount();
        [NativeConditional("ENABLE_XR")]
        [NativeMethod("TryGetMirrorModeByIndex")]
        public void GetMirrorBlitModeByIndex(int index, out XRMirrorViewBlitModeDesc mode);
    }
}

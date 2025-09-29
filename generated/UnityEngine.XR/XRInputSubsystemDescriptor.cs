#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_XR")]
    [NativeHeader("Modules/XR/XRPrefix.h")]
    [NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystemDescriptor.h")]
    [UsedByNativeCode]
    public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
    {
        public XRInputSubsystemDescriptor();

        [NativeConditional("ENABLE_XR")]
        public bool disablesLegacyInput { get; }
    }
}

#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Subsystems
{
    [NativeType(Header = "Modules/Subsystems/Example/ExampleSubsystemDescriptor.h")]
    [UsedByNativeCode]
    public class ExampleSubsystemDescriptor : IntegratedSubsystemDescriptor<ExampleSubsystem>
    {

        public ExampleSubsystemDescriptor();

        public bool supportsEditorMode { get; }
        public bool disableBackbufferMSAA { get; }
        public bool stereoscopicBackbuffer { get; }
        public bool usePBufferEGL { get; }
    }
}

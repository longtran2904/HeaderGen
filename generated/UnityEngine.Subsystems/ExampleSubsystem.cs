#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Subsystems
{
    [NativeType(Header = "Modules/Subsystems/Example/ExampleSubsystem.h")]
    [UsedByNativeCode]
    public class ExampleSubsystem : IntegratedSubsystem<ExampleSubsystemDescriptor>
    {

        public ExampleSubsystem();

        public void PrintExample();
        public bool GetBool();
    }
}

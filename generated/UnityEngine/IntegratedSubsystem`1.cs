#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
    public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem where TSubsystemDescriptor : ISubsystemDescriptor
    {

        public IntegratedSubsystem();

        public TSubsystemDescriptor subsystemDescriptor { get; }
        public TSubsystemDescriptor SubsystemDescriptor { get; }
    }
}

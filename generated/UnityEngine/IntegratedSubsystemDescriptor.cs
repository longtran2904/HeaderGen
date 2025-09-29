#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode("SubsystemDescriptorBase")]
    public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor, ISubsystemDescriptorImpl
    {

        protected IntegratedSubsystemDescriptor();

        public string id { get; }
    }
}

#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using System;

namespace UnityEngine.SubsystemsImplementation
{
    public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor
    {

        protected SubsystemDescriptorWithProvider();

        public string id { get; set; }
        protected internal Type providerType { get; set; }
        protected internal Type subsystemTypeOverride { get; set; }
    }
}

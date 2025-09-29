#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using System;

namespace UnityEngine
{
    public abstract class SubsystemDescriptor : ISubsystemDescriptor
    {
        protected SubsystemDescriptor();

        public string id { get; set; }
        public Type subsystemImplementationType { get; set; }
    }
}

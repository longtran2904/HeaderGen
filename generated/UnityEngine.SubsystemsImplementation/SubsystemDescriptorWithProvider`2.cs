#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine.SubsystemsImplementation
{
    public class SubsystemDescriptorWithProvider<TSubsystem, TProvider> : SubsystemDescriptorWithProvider where TSubsystem : SubsystemWithProvider, new() where TProvider : SubsystemProvider<TSubsystem>
    {

        public SubsystemDescriptorWithProvider();

        public TSubsystem Create();
    }
}

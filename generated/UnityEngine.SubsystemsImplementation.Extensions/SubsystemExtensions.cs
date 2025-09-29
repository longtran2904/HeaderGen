#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine.SubsystemsImplementation.Extensions
{
    public static class SubsystemExtensions
    {
        public static TProvider GetProvider<TSubsystem, TDescriptor, TProvider>(this SubsystemWithProvider<TSubsystem, TDescriptor, TProvider> subsystem) where TSubsystem : SubsystemWithProvider, new() where TDescriptor : SubsystemDescriptorWithProvider<TSubsystem, TProvider> where TProvider : SubsystemProvider<TSubsystem>;
    }
}

#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine.SubsystemsImplementation
{
    public abstract class SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider> : SubsystemWithProvider where TSubsystem : SubsystemWithProvider, new() where TSubsystemDescriptor : SubsystemDescriptorWithProvider where TProvider : SubsystemProvider<TSubsystem>
    {

        protected SubsystemWithProvider();

        public TSubsystemDescriptor subsystemDescriptor { get; }
        protected internal TProvider provider { get; }

        protected virtual void OnCreate();
        protected override void OnStart();
        protected override void OnStop();
        protected override void OnDestroy();
    }
}

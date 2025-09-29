#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine.SubsystemsImplementation
{
    public abstract class SubsystemProvider<TSubsystem> : SubsystemProvider where TSubsystem : SubsystemWithProvider, new()
    {

        protected SubsystemProvider();

        protected internal virtual bool TryInitialize();
        public abstract void Start();
        public abstract void Stop();
        public abstract void Destroy();
    }
}

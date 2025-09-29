#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine.SubsystemsImplementation
{
    public abstract class SubsystemWithProvider : ISubsystem
    {

        protected SubsystemWithProvider();

        public bool running { get; }

        public void Start();
        protected abstract void OnStart();
        public void Stop();
        protected abstract void OnStop();
        public void Destroy();
        protected abstract void OnDestroy();
    }
}

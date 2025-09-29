#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine
{
    public abstract class Subsystem : ISubsystem
    {
        protected Subsystem();

        public abstract bool running { get; }

        public abstract void Start();
        public abstract void Stop();
        public void Destroy();
        protected abstract void OnDestroy();
    }
}

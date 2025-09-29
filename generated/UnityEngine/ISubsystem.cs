#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine
{
    public interface ISubsystem
    {
        bool running { get; }

        void Start();
        void Stop();
        void Destroy();
    }
}

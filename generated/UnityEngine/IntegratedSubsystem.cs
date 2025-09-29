#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Subsystems/Subsystem.h")]
    [UsedByNativeCode]
    public class IntegratedSubsystem : ISubsystem
    {

        public IntegratedSubsystem();

        public bool running { get; }

        public void Start();
        public void Stop();
        public void Destroy();
    }
}

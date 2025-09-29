#region UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll
#endregion

namespace UnityEngine.SubsystemsImplementation
{
    public class SubsystemProxy<TSubsystem, TProvider> where TSubsystem : SubsystemWithProvider, new() where TProvider : SubsystemProvider<TSubsystem>
    {

        public TProvider provider { get; }
        public bool running { get; set; }
    }
}

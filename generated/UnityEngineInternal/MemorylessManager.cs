#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngineInternal
{
    [NativeHeader("Runtime/Misc/PlayerSettings.h")]
    public class MemorylessManager
    {

        public MemorylessManager();

        public static MemorylessMode depthMemorylessMode { get; set; }
    }
}

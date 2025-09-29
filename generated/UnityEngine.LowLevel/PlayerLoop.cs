#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
    [MovedFrom("UnityEngine.Experimental.LowLevel")]
    public class PlayerLoop
    {
        public PlayerLoop();

        public static PlayerLoopSystem GetDefaultPlayerLoop();
        public static PlayerLoopSystem GetCurrentPlayerLoop();
        public static void SetPlayerLoop(PlayerLoopSystem loop);
    }
}

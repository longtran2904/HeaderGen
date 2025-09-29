#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Playables
{
    public enum PlayState
    {
        Paused = 0,
        Playing = 1,
        [Obsolete("Delayed is obsolete; use a custom ScriptPlayable to implement this feature", False)]
        Delayed = 2
    }
}

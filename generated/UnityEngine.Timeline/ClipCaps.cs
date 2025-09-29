#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;

namespace UnityEngine.Timeline
{
    [Flags]
    public enum ClipCaps
    {

        None = 0,
        Looping = 1,
        Extrapolation = 2,
        ClipIn = 4,
        SpeedMultiplier = 8,
        Blending = 16,
        AutoScale = 40,
        All = -1
    }
}

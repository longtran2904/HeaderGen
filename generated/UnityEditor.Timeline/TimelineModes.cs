#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;

namespace UnityEditor.Timeline
{
    [Flags]
    public enum TimelineModes
    {
        Active = 1,
        ReadOnly = 2,
        Inactive = 4,
        Disabled = 8,
        AssetEdition = 16,
        Default = 17
    }
}

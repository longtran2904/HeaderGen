#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using System;

namespace UnityEditor.Timeline
{
    [Flags]
    public enum RefreshReason
    {

        WindowNeedsRedraw = 1,
        SceneNeedsUpdate = 2,
        ContentsModified = 4,
        ContentsAddedOrRemoved = 8
    }
}

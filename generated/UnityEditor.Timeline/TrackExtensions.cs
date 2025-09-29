#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public static class TrackExtensions
    {

        public static bool IsCollapsed(this TrackAsset track);
        public static void SetCollapsed(this TrackAsset track, bool collapsed);
        public static bool IsVisibleInHierarchy(this TrackAsset track);
    }
}

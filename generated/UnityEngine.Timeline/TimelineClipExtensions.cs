#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

namespace UnityEngine.Timeline
{
    public static class TimelineClipExtensions
    {

        public static void MoveToTrack(this TimelineClip clip, TrackAsset destinationTrack);
        public static bool TryMoveToTrack(this TimelineClip clip, TrackAsset destinationTrack);
    }
}

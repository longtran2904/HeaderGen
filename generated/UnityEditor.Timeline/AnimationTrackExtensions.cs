#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEngine.Timeline;

namespace UnityEditor.Timeline
{
    public static class AnimationTrackExtensions
    {

        public static bool CanStartRecording(this AnimationTrack track);
        public static bool IsRecording(this AnimationTrack track);
        public static bool StartRecording(this AnimationTrack track);
        public static void StopRecording(this AnimationTrack track);
    }
}

#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Timeline
{
    public struct ClipBackgroundRegion
    {

        public ClipBackgroundRegion(Rect _position, double _startTime, double _endTime);

        public Rect position { get; }
        public double startTime { get; }
        public double endTime { get; }

        public override bool Equals(object obj);
        public bool Equals(ClipBackgroundRegion other);
        public override int GetHashCode();

        public static bool operator ==(ClipBackgroundRegion region1, ClipBackgroundRegion region2);
        public static bool operator !=(ClipBackgroundRegion region1, ClipBackgroundRegion region2);
    }
}

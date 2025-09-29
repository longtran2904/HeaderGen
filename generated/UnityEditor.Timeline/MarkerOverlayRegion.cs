#region Unity.Timeline.Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.Editor.dll
#endregion

using UnityEngine;

namespace UnityEditor.Timeline
{
    public struct MarkerOverlayRegion
    {

        public MarkerOverlayRegion(Rect _markerRegion, Rect _timelineRegion, double _startTime, double _endTime);
        public MarkerOverlayRegion(Rect _markerRegion, Rect _timelineRegion, double _startTime, double _endTime, float _trackOffset);

        public Rect markerRegion { get; }
        public Rect timelineRegion { get; }
        public Rect trackRegion { get; }
        public double startTime { get; }
        public double endTime { get; }

        public override bool Equals(object obj);
        public bool Equals(MarkerOverlayRegion other);
        public override int GetHashCode();

        public static bool operator ==(MarkerOverlayRegion region1, MarkerOverlayRegion region2);
        public static bool operator !=(MarkerOverlayRegion region1, MarkerOverlayRegion region2);
    }
}

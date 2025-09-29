#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public class TimelinePlayable : PlayableBehaviour
    {

        public TimelinePlayable();

        public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs);
        public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs);
        public override void PrepareFrame(Playable playable, FrameData info);
    }
}

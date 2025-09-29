#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [ExcludeFromPreset]
    [SupportsChildTracks(null, 2147483647)]
    [TimelineHelpURL(typeof(GroupTrack))]
    [TrackClipType(typeof(TrackAsset))]
    public class GroupTrack : TrackAsset
    {

        public GroupTrack();

        public override IEnumerable<PlayableBinding> outputs { get; }
    }
}

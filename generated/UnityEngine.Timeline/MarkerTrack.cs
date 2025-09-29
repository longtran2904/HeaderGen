#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [ExcludeFromPreset]
    [HideInMenu]
    [TimelineHelpURL(typeof(MarkerTrack))]
    [TrackBindingType(typeof(GameObject))]
    public class MarkerTrack : TrackAsset
    {

        public MarkerTrack();

        public override IEnumerable<PlayableBinding> outputs { get; }
    }
}

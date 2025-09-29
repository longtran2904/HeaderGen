#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [DisplayName("Audio Clip")]
    public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
    {

        public AudioPlayableAsset();

        public AudioClip clip { get; set; }
        public bool loop { get; set; }
        public override double duration { get; }
        public override IEnumerable<PlayableBinding> outputs { get; }
        public ClipCaps clipCaps { get; }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject go);
    }
}

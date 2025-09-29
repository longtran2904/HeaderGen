#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [ExcludeFromPreset]
    [TimelineHelpURL(typeof(AudioTrack))]
    [TrackBindingType(typeof(AudioSource))]
    [TrackClipType(typeof(AudioPlayableAsset), False)]
    public class AudioTrack : TrackAsset
    {
        public AudioTrack();

        public override IEnumerable<PlayableBinding> outputs { get; }

        public TimelineClip CreateClip(AudioClip clip);
    }
}

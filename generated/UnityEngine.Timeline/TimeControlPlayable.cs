#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public class TimeControlPlayable : PlayableBehaviour
    {
        public TimeControlPlayable();

        public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl);
        public void Initialize(ITimeControl timeControl);
        public override void PrepareFrame(Playable playable, FrameData info);
        public override void OnBehaviourPlay(Playable playable, FrameData info);
        public override void OnBehaviourPause(Playable playable, FrameData info);
    }
}

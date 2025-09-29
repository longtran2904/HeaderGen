#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public class ParticleControlPlayable : PlayableBehaviour
    {

        public ParticleControlPlayable();

        public ParticleSystem particleSystem { get; }

        public static ScriptPlayable<ParticleControlPlayable> Create(PlayableGraph graph, ParticleSystem component, uint randomSeed);
        public void Initialize(ParticleSystem ps, uint randomSeed);
        public override void OnPlayableDestroy(Playable playable);
        public override void PrepareFrame(Playable playable, FrameData data);
        public override void OnBehaviourPlay(Playable playable, FrameData info);
        public override void OnBehaviourPause(Playable playable, FrameData info);
    }
}

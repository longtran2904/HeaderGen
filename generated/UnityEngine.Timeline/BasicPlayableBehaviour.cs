#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
    public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour
    {

        public BasicPlayableBehaviour();

        public virtual double duration { get; }
        public virtual IEnumerable<PlayableBinding> outputs { get; }

        public virtual void OnGraphStart(Playable playable);
        public virtual void OnGraphStop(Playable playable);
        public virtual void OnPlayableCreate(Playable playable);
        public virtual void OnPlayableDestroy(Playable playable);
        public virtual void OnBehaviourPlay(Playable playable, FrameData info);
        public virtual void OnBehaviourPause(Playable playable, FrameData info);
        public virtual void PrepareFrame(Playable playable, FrameData info);
        public virtual void ProcessFrame(Playable playable, FrameData info, object playerData);
        public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner);
    }
}

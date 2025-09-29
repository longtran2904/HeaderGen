#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public class PrefabControlPlayable : PlayableBehaviour
    {
        public PrefabControlPlayable();

        public GameObject prefabInstance { get; }

        public static ScriptPlayable<PrefabControlPlayable> Create(PlayableGraph graph, GameObject prefabGameObject, Transform parentTransform);
        public GameObject Initialize(GameObject prefabGameObject, Transform parentTransform);
        public override void OnPlayableDestroy(Playable playable);
        public override void OnBehaviourPlay(Playable playable, FrameData info);
        public override void OnBehaviourPause(Playable playable, FrameData info);
    }
}

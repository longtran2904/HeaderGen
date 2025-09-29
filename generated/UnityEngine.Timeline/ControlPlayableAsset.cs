#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    [NotKeyable]
    public class ControlPlayableAsset : PlayableAsset, IPropertyPreview, ITimelineClipAsset
    {
        [SerializeField]
        public ExposedReference<GameObject> sourceGameObject;
        [SerializeField]
        public GameObject prefabGameObject;
        [SerializeField]
        public bool updateParticle;
        [SerializeField]
        public uint particleRandomSeed;
        [SerializeField]
        public bool updateDirector;
        [SerializeField]
        public bool updateITimeControl;
        [SerializeField]
        public bool searchHierarchy;
        [SerializeField]
        public bool active;
        [SerializeField]
        public ActivationControlPlayable.PostPlaybackState postPlayback;

        public ControlPlayableAsset();

        public override double duration { get; }
        public ClipCaps clipCaps { get; }

        public void OnEnable();
        public override Playable CreatePlayable(PlayableGraph graph, GameObject go);
        public void GatherProperties(PlayableDirector director, IPropertyCollector driver);
    }
}

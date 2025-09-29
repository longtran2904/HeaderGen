#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [AssetFileNameExtension("playable", new[] { })]
    [RequiredByNativeCode]
    public abstract class PlayableAsset : ScriptableObject, IPlayableAsset
    {

        protected PlayableAsset();

        public virtual double duration { get; }
        public virtual IEnumerable<PlayableBinding> outputs { get; }

        public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);
    }
}

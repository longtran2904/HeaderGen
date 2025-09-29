#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Playables
{
    public interface IPlayableAsset
    {

        double duration { get; }
        IEnumerable<PlayableBinding> outputs { get; }

        Playable CreatePlayable(PlayableGraph graph, GameObject owner);
    }
}

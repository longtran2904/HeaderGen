#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Playables;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    public interface IAnimationWindowPreview
    {
        void StartPreview();
        void StopPreview();
        void UpdatePreviewGraph(PlayableGraph graph);
        Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable);
    }
}

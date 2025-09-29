#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Playables;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    public interface IAnimationJobPlayable : IPlayable
    {

        T GetJobData<T>() where T : IAnimationJob, struct;
        void SetJobData<T>(T jobData) where T : IAnimationJob, struct;
    }
}

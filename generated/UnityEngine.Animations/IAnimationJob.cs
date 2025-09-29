#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [JobProducerType(typeof(ProcessAnimationJobStruct<>))]
    [MovedFrom("UnityEngine.Experimental.Animations")]
    public interface IAnimationJob
    {
        void ProcessAnimation(AnimationStream stream);
        void ProcessRootMotion(AnimationStream stream);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    public interface IPlayableBehaviour
    {

        [RequiredByNativeCode]
        void OnGraphStart(Playable playable);
        [RequiredByNativeCode]
        void OnGraphStop(Playable playable);
        [RequiredByNativeCode]
        void OnPlayableCreate(Playable playable);
        [RequiredByNativeCode]
        void OnPlayableDestroy(Playable playable);
        [RequiredByNativeCode]
        void OnBehaviourPlay(Playable playable, FrameData info);
        [RequiredByNativeCode]
        void OnBehaviourPause(Playable playable, FrameData info);
        [RequiredByNativeCode]
        void PrepareFrame(Playable playable, FrameData info);
        [RequiredByNativeCode]
        void ProcessFrame(Playable playable, FrameData info, object playerData);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [RequiredByNativeCode]
    public abstract class PlayableBehaviour : ICloneable, IPlayableBehaviour
    {

        public PlayableBehaviour();

        public virtual void OnGraphStart(Playable playable);
        public virtual void OnGraphStop(Playable playable);
        public virtual void OnPlayableCreate(Playable playable);
        public virtual void OnPlayableDestroy(Playable playable);
        [Obsolete("OnBehaviourDelay is obsolete; use a custom ScriptPlayable to implement this feature", False)]
        public virtual void OnBehaviourDelay(Playable playable, FrameData info);
        public virtual void OnBehaviourPlay(Playable playable, FrameData info);
        public virtual void OnBehaviourPause(Playable playable, FrameData info);
        public virtual void PrepareData(Playable playable, FrameData info);
        public virtual void PrepareFrame(Playable playable, FrameData info);
        public virtual void ProcessFrame(Playable playable, FrameData info, object playerData);
        public virtual object Clone();
    }
}

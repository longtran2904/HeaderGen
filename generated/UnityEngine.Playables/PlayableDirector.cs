#region UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.DirectorModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [NativeHeader("Runtime/Mono/MonoBehaviour.h")]
    [NativeHeader("Modules/Director/PlayableDirector.h")]
    [RequiredByNativeCode]
    public class PlayableDirector : Behaviour, IExposedPropertyTable
    {
        public PlayableDirector();

        public PlayState state { get; }
        public DirectorWrapMode extrapolationMode { get; set; }
        public PlayableAsset playableAsset { get; set; }
        public PlayableGraph playableGraph { get; }
        public bool playOnAwake { get; set; }
        public DirectorUpdateMode timeUpdateMode { get; set; }
        public double time { get; set; }
        public double initialTime { get; set; }
        public double duration { get; }

        public event Action<PlayableDirector> played;
        public event Action<PlayableDirector> paused;
        public event Action<PlayableDirector> stopped;

        public void DeferredEvaluate();
        public void Play(PlayableAsset asset);
        public void Play(PlayableAsset asset, DirectorWrapMode mode);
        public void SetGenericBinding(Object key, Object value);
        [NativeThrows]
        public void Evaluate();
        [NativeThrows]
        public void Play();
        public void Stop();
        public void Pause();
        public void Resume();
        [NativeThrows]
        public void RebuildGraph();
        public void ClearReferenceValue(PropertyName id);
        public void SetReferenceValue(PropertyName id, Object value);
        public Object GetReferenceValue(PropertyName id, out bool idValid);
        [NativeMethod("GetBindingFor")]
        public Object GetGenericBinding(Object key);
        [NativeMethod("ClearBindingFor")]
        public void ClearGenericBinding(Object key);
        [NativeThrows]
        public void RebindPlayableGraphOutputs();
    }
}

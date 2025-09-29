#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.Collections;
using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [NativeHeader("Modules/Animation/Animation.h")]
    public sealed class Animation : Behaviour, IEnumerable
    {

        public Animation();

        public AnimationState this[string name] { get; }
        public AnimationClip clip { get; set; }
        public bool playAutomatically { get; set; }
        public WrapMode wrapMode { get; set; }
        public bool isPlaying { get; }
        public bool animatePhysics { get; set; }
        [Obsolete("Use cullingType instead")]
        public bool animateOnlyIfVisible { get; set; }
        public AnimationCullingType cullingType { get; set; }
        public Bounds localBounds { get; set; }

        public void Stop();
        public void Stop(string name);
        public void Rewind();
        public void Rewind(string name);
        public void Sample();
        public bool IsPlaying(string name);
        [ExcludeFromDocs]
        public bool Play();
        public bool Play([DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
        [ExcludeFromDocs]
        public bool Play(string animation);
        public bool Play(string animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
        [ExcludeFromDocs]
        public void CrossFade(string animation);
        [ExcludeFromDocs]
        public void CrossFade(string animation, float fadeLength);
        public void CrossFade(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
        [ExcludeFromDocs]
        public void Blend(string animation);
        [ExcludeFromDocs]
        public void Blend(string animation, float targetWeight);
        public void Blend(string animation, [DefaultValue("1.0F")] float targetWeight, [DefaultValue("0.3F")] float fadeLength);
        [ExcludeFromDocs]
        public AnimationState CrossFadeQueued(string animation);
        [ExcludeFromDocs]
        public AnimationState CrossFadeQueued(string animation, float fadeLength);
        [ExcludeFromDocs]
        public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue);
        [FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = True)]
        public AnimationState CrossFadeQueued(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
        [ExcludeFromDocs]
        public AnimationState PlayQueued(string animation);
        [ExcludeFromDocs]
        public AnimationState PlayQueued(string animation, QueueMode queue);
        [FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = True)]
        public AnimationState PlayQueued(string animation, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
        public void AddClip(AnimationClip clip, string newName);
        [ExcludeFromDocs]
        public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame);
        public void AddClip([NotNull("NullExceptionObject")] AnimationClip clip, string newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame);
        public void RemoveClip([NotNull("NullExceptionObject")] AnimationClip clip);
        public void RemoveClip(string clipName);
        public int GetClipCount();
        [Obsolete("use PlayMode instead of AnimationPlayMode.")]
        public bool Play(AnimationPlayMode mode);
        [Obsolete("use PlayMode instead of AnimationPlayMode.")]
        public bool Play(string animation, AnimationPlayMode mode);
        public void SyncLayer(int layer);
        public IEnumerator GetEnumerator();
        public AnimationClip GetClip(string name);
    }
}

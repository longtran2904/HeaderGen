#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/AnimationState.h")]
    [UsedByNativeCode]
    public sealed class AnimationState : TrackedReference
    {

        public AnimationState();

        public bool enabled { get; set; }
        public float weight { get; set; }
        public WrapMode wrapMode { get; set; }
        public float time { get; set; }
        public float normalizedTime { get; set; }
        public float speed { get; set; }
        public float normalizedSpeed { get; set; }
        public float length { get; }
        public int layer { get; set; }
        public AnimationClip clip { get; }
        public string name { get; set; }
        public AnimationBlendMode blendMode { get; set; }

        [ExcludeFromDocs]
        public void AddMixingTransform(Transform mix);
        public void AddMixingTransform([NotNull("NullExceptionObject")] Transform mix, [DefaultValue("true")] bool recursive);
        public void RemoveMixingTransform([NotNull("NullExceptionObject")] Transform mix);
    }
}

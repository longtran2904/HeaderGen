#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
    public struct PropertyStreamHandle
    {
        public bool IsValid(AnimationStream stream);
        public void Resolve(AnimationStream stream);
        public bool IsResolved(AnimationStream stream);
        public float GetFloat(AnimationStream stream);
        public void SetFloat(AnimationStream stream, float value);
        public int GetInt(AnimationStream stream);
        public void SetInt(AnimationStream stream, int value);
        public bool GetBool(AnimationStream stream);
        public void SetBool(AnimationStream stream, bool value);
        public bool GetReadMask(AnimationStream stream);
    }
}

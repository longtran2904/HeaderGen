#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
    [MovedFrom(True, "UnityEditor.Animations", "UnityEditor", null)]
    [NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
    [NativeHeader("Modules/Animation/AvatarMask.h")]
    [UsedByNativeCode]
    public sealed class AvatarMask : Object
    {
        public AvatarMask();

        [Obsolete("AvatarMask.humanoidBodyPartCount is deprecated, use AvatarMaskBodyPart.LastBodyPart instead.")]
        public int humanoidBodyPartCount { get; }
        public int transformCount { get; set; }

        [NativeMethod("GetBodyPart")]
        public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index);
        [NativeMethod("SetBodyPart")]
        public void SetHumanoidBodyPartActive(AvatarMaskBodyPart index, bool value);
        public void AddTransformPath(Transform transform);
        public void AddTransformPath([NotNull("ArgumentNullException")] Transform transform, [DefaultValue("true")] bool recursive);
        public void RemoveTransformPath(Transform transform);
        public void RemoveTransformPath([NotNull("ArgumentNullException")] Transform transform, [DefaultValue("true")] bool recursive);
        public string GetTransformPath(int index);
        public void SetTransformPath(int index, string path);
        public bool GetTransformActive(int index);
        public void SetTransformActive(int index, bool value);
    }
}

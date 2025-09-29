#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
    [NativeHeader("Modules/Animation/HumanPoseHandler.h")]
    public class HumanPoseHandler : IDisposable
    {

        public HumanPoseHandler(Avatar avatar, Transform root);
        public HumanPoseHandler(Avatar avatar, string[] jointPaths);

        public void Dispose();
        public void GetHumanPose(ref HumanPose humanPose);
        public void SetHumanPose(ref HumanPose humanPose);
        public void GetInternalHumanPose(ref HumanPose humanPose);
        public void SetInternalHumanPose(ref HumanPose humanPose);
        public void GetInternalAvatarPose(NativeArray<float> avatarPose);
        public void SetInternalAvatarPose(NativeArray<float> avatarPose);
    }
}

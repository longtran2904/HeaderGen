#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use AnimatorClipInfo instead (UnityUpgradable) -> AnimatorClipInfo", True)]
    public struct AnimationInfo
    {

        public AnimationClip clip { get; }
        public float weight { get; }
    }
}

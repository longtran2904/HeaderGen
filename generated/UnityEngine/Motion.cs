#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/Motion.h")]
    public class Motion : Object
    {
        protected Motion();

        public float averageDuration { get; }
        public float averageAngularSpeed { get; }
        public Vector3 averageSpeed { get; }
        public float apparentSpeed { get; }
        public bool isLooping { get; }
        public bool legacy { get; }
        public bool isHumanMotion { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("isAnimatorMotion is not supported anymore, please use !legacy instead.", True)]
        public bool isAnimatorMotion { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("ValidateIfRetargetable is not supported anymore, please use isHumanMotion instead.", True)]
        public bool ValidateIfRetargetable(bool val);
    }
}

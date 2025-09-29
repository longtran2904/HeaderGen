#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine.Playables
{
    public struct PlayableBinding
    {
        public static readonly PlayableBinding[] None;
        public static readonly double DefaultDuration;

        public string streamName { get; set; }
        public Object sourceObject { get; set; }
        public Type outputTargetType { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("sourceBindingType is no longer supported on PlayableBinding. Use outputBindingType instead to get the required output target type, and the appropriate binding create method (e.g. AnimationPlayableBinding.Create(name, key)) to create PlayableBindings", True)]
        public Type sourceBindingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("streamType is no longer supported on PlayableBinding. Use the appropriate binding create method (e.g. AnimationPlayableBinding.Create(name, key)) instead.", True)]
        public DataStreamType streamType { get; set; }
    }
}

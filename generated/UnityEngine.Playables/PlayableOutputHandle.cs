#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
    [UsedByNativeCode]
    public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
    {

        public static PlayableOutputHandle Null { get; }

        public override int GetHashCode();
        public override bool Equals(object p);
        public bool Equals(PlayableOutputHandle other);

        public static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs);
        public static bool operator !=(PlayableOutputHandle lhs, PlayableOutputHandle rhs);
    }
}

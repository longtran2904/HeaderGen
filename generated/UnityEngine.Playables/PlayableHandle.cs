#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
    [NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [UsedByNativeCode]
    public struct PlayableHandle : IEquatable<PlayableHandle>
    {

        public static PlayableHandle Null { get; }

        public override bool Equals(object p);
        public bool Equals(PlayableHandle other);
        public override int GetHashCode();

        public static bool operator ==(PlayableHandle x, PlayableHandle y);
        public static bool operator !=(PlayableHandle x, PlayableHandle y);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
    [NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
    [NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [RequiredByNativeCode]
    [StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable>, IPlayable
    {
        public static TextureMixerPlayable Create(PlayableGraph graph);
        public PlayableHandle GetHandle();
        public bool Equals(TextureMixerPlayable other);

        public static implicit operator Playable(TextureMixerPlayable playable);
        public static explicit operator TextureMixerPlayable(Playable playable);
    }
}

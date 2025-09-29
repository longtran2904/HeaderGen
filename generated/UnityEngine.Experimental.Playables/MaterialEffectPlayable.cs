#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
    [NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
    [NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [RequiredByNativeCode]
    [StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>, IPlayable
    {

        public static MaterialEffectPlayable Create(PlayableGraph graph, Material material, int pass = -1);
        public PlayableHandle GetHandle();
        public bool Equals(MaterialEffectPlayable other);
        public Material GetMaterial();
        public void SetMaterial(Material value);
        public int GetPass();
        public void SetPass(int value);

        public static implicit operator Playable(MaterialEffectPlayable playable);
        public static explicit operator MaterialEffectPlayable(Playable playable);
    }
}

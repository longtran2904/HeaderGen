#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
    [NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
    [NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [RequiredByNativeCode]
    [StaticAccessor("CameraPlayableBindings", StaticAccessorType.DoubleColon)]
    public struct CameraPlayable : IEquatable<CameraPlayable>, IPlayable
    {
        public static CameraPlayable Create(PlayableGraph graph, Camera camera);
        public PlayableHandle GetHandle();
        public bool Equals(CameraPlayable other);
        public Camera GetCamera();
        public void SetCamera(Camera value);

        public static implicit operator Playable(CameraPlayable playable);
        public static explicit operator CameraPlayable(Playable playable);
    }
}

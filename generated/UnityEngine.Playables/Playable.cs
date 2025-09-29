#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [RequiredByNativeCode]
    public struct Playable : IEquatable<Playable>, IPlayable
    {
        public static Playable Null { get; }

        public static Playable Create(PlayableGraph graph, int inputCount = 0);
        public PlayableHandle GetHandle();
        public bool IsPlayableOfType<T>() where T : IPlayable, struct;
        public Type GetPlayableType();
        public bool Equals(Playable other);
    }
}

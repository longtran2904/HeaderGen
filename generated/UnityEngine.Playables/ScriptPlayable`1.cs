#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Playables
{
    public struct ScriptPlayable<T> : IEquatable<ScriptPlayable<T>>, IPlayable where T : IPlayableBehaviour, class, new()
    {

        public static ScriptPlayable<T> Null { get; }

        public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0);
        public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0);
        public PlayableHandle GetHandle();
        public T GetBehaviour();
        public bool Equals(ScriptPlayable<T> other);

        public static implicit operator Playable(ScriptPlayable<T> playable);
        public static explicit operator ScriptPlayable<T>(Playable playable);
    }
}

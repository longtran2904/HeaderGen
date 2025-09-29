#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [RequiredByNativeCode]
    public struct PlayableOutput : IEquatable<PlayableOutput>, IPlayableOutput
    {

        public static PlayableOutput Null { get; }

        public PlayableOutputHandle GetHandle();
        public bool IsPlayableOutputOfType<T>() where T : IPlayableOutput, struct;
        public Type GetPlayableOutputType();
        public bool Equals(PlayableOutput other);
    }
}

#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [RequiredByNativeCode]
    public struct ScriptPlayableOutput : IPlayableOutput
    {

        public static ScriptPlayableOutput Null { get; }

        public static ScriptPlayableOutput Create(PlayableGraph graph, string name);
        public PlayableOutputHandle GetHandle();

        public static implicit operator PlayableOutput(ScriptPlayableOutput output);
        public static explicit operator ScriptPlayableOutput(PlayableOutput output);
    }
}

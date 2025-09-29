#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
    [NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
    [NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
    [NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
    [NativeHeader("Runtime/Director/Core/HPlayable.h")]
    [UsedByNativeCode]
    public struct PlayableGraph
    {

        public Playable GetRootPlayable(int index);
        public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : IPlayable, struct where V : IPlayable, struct;
        public void Disconnect<U>(U input, int inputPort) where U : IPlayable, struct;
        public void DestroyPlayable<U>(U playable) where U : IPlayable, struct;
        public void DestroySubgraph<U>(U playable) where U : IPlayable, struct;
        public void DestroyOutput<U>(U output) where U : IPlayableOutput, struct;
        public int GetOutputCountByType<T>() where T : IPlayableOutput, struct;
        public PlayableOutput GetOutput(int index);
        public PlayableOutput GetOutputByType<T>(int index) where T : IPlayableOutput, struct;
        public void Evaluate();
        public static PlayableGraph Create();
        public static PlayableGraph Create(string name);
        [FreeFunction("PlayableGraphBindings::Destroy", ThrowsException = True, HasExplicitThis = True)]
        public void Destroy();
        public bool IsValid();
        [FreeFunction("PlayableGraphBindings::IsPlaying", ThrowsException = True, HasExplicitThis = True)]
        public bool IsPlaying();
        [FreeFunction("PlayableGraphBindings::IsDone", ThrowsException = True, HasExplicitThis = True)]
        public bool IsDone();
        [FreeFunction("PlayableGraphBindings::Play", ThrowsException = True, HasExplicitThis = True)]
        public void Play();
        [FreeFunction("PlayableGraphBindings::Stop", ThrowsException = True, HasExplicitThis = True)]
        public void Stop();
        [FreeFunction("PlayableGraphBindings::Evaluate", ThrowsException = True, HasExplicitThis = True)]
        public void Evaluate([DefaultValue("0")] float deltaTime);
        [FreeFunction("PlayableGraphBindings::GetTimeUpdateMode", ThrowsException = True, HasExplicitThis = True)]
        public DirectorUpdateMode GetTimeUpdateMode();
        [FreeFunction("PlayableGraphBindings::SetTimeUpdateMode", ThrowsException = True, HasExplicitThis = True)]
        public void SetTimeUpdateMode(DirectorUpdateMode value);
        [FreeFunction("PlayableGraphBindings::GetResolver", ThrowsException = True, HasExplicitThis = True)]
        public IExposedPropertyTable GetResolver();
        [FreeFunction("PlayableGraphBindings::SetResolver", ThrowsException = True, HasExplicitThis = True)]
        public void SetResolver(IExposedPropertyTable value);
        [FreeFunction("PlayableGraphBindings::GetPlayableCount", ThrowsException = True, HasExplicitThis = True)]
        public int GetPlayableCount();
        [FreeFunction("PlayableGraphBindings::GetRootPlayableCount", ThrowsException = True, HasExplicitThis = True)]
        public int GetRootPlayableCount();
        [FreeFunction("PlayableGraphBindings::GetOutputCount", ThrowsException = True, HasExplicitThis = True)]
        public int GetOutputCount();
        [FreeFunction("PlayableGraphBindings::GetEditorName", ThrowsException = True, HasExplicitThis = True)]
        public string GetEditorName();
    }
}

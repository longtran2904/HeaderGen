#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Playables
{
    public static class PlayableExtensions
    {

        public static bool IsNull<U>(this U playable) where U : IPlayable, struct;
        public static bool IsValid<U>(this U playable) where U : IPlayable, struct;
        public static void Destroy<U>(this U playable) where U : IPlayable, struct;
        public static PlayableGraph GetGraph<U>(this U playable) where U : IPlayable, struct;
        [Obsolete("SetPlayState() has been deprecated. Use Play(), Pause() or SetDelay() instead", False)]
        public static void SetPlayState<U>(this U playable, PlayState value) where U : IPlayable, struct;
        public static PlayState GetPlayState<U>(this U playable) where U : IPlayable, struct;
        public static void Play<U>(this U playable) where U : IPlayable, struct;
        public static void Pause<U>(this U playable) where U : IPlayable, struct;
        public static void SetSpeed<U>(this U playable, double value) where U : IPlayable, struct;
        public static double GetSpeed<U>(this U playable) where U : IPlayable, struct;
        public static void SetDuration<U>(this U playable, double value) where U : IPlayable, struct;
        public static double GetDuration<U>(this U playable) where U : IPlayable, struct;
        public static void SetTime<U>(this U playable, double value) where U : IPlayable, struct;
        public static double GetTime<U>(this U playable) where U : IPlayable, struct;
        public static double GetPreviousTime<U>(this U playable) where U : IPlayable, struct;
        public static void SetDone<U>(this U playable, bool value) where U : IPlayable, struct;
        public static bool IsDone<U>(this U playable) where U : IPlayable, struct;
        public static void SetPropagateSetTime<U>(this U playable, bool value) where U : IPlayable, struct;
        public static bool GetPropagateSetTime<U>(this U playable) where U : IPlayable, struct;
        public static bool CanChangeInputs<U>(this U playable) where U : IPlayable, struct;
        public static bool CanSetWeights<U>(this U playable) where U : IPlayable, struct;
        public static bool CanDestroy<U>(this U playable) where U : IPlayable, struct;
        public static void SetInputCount<U>(this U playable, int value) where U : IPlayable, struct;
        public static int GetInputCount<U>(this U playable) where U : IPlayable, struct;
        public static void SetOutputCount<U>(this U playable, int value) where U : IPlayable, struct;
        public static int GetOutputCount<U>(this U playable) where U : IPlayable, struct;
        public static Playable GetInput<U>(this U playable, int inputPort) where U : IPlayable, struct;
        public static Playable GetOutput<U>(this U playable, int outputPort) where U : IPlayable, struct;
        public static void SetInputWeight<U>(this U playable, int inputIndex, float weight) where U : IPlayable, struct;
        public static void SetInputWeight<U, V>(this U playable, V input, float weight) where U : IPlayable, struct where V : IPlayable, struct;
        public static float GetInputWeight<U>(this U playable, int inputIndex) where U : IPlayable, struct;
        public static void ConnectInput<U, V>(this U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) where U : IPlayable, struct where V : IPlayable, struct;
        public static void ConnectInput<U, V>(this U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) where U : IPlayable, struct where V : IPlayable, struct;
        public static void DisconnectInput<U>(this U playable, int inputPort) where U : IPlayable, struct;
        public static int AddInput<U, V>(this U playable, V sourcePlayable, int sourceOutputIndex, float weight = 0) where U : IPlayable, struct where V : IPlayable, struct;
        [Obsolete("SetDelay is obsolete; use a custom ScriptPlayable to implement this feature", False)]
        public static void SetDelay<U>(this U playable, double delay) where U : IPlayable, struct;
        [Obsolete("GetDelay is obsolete; use a custom ScriptPlayable to implement this feature", False)]
        public static double GetDelay<U>(this U playable) where U : IPlayable, struct;
        [Obsolete("IsDelayed is obsolete; use a custom ScriptPlayable to implement this feature", False)]
        public static bool IsDelayed<U>(this U playable) where U : IPlayable, struct;
        public static void SetLeadTime<U>(this U playable, float value) where U : IPlayable, struct;
        public static float GetLeadTime<U>(this U playable) where U : IPlayable, struct;
        public static PlayableTraversalMode GetTraversalMode<U>(this U playable) where U : IPlayable, struct;
        public static void SetTraversalMode<U>(this U playable, PlayableTraversalMode mode) where U : IPlayable, struct;
    }
}

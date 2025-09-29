#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Playables
{
    public struct FrameData
    {

        public ulong frameId { get; }
        public float deltaTime { get; }
        public float weight { get; }
        public float effectiveWeight { get; }
        [Obsolete("effectiveParentDelay is obsolete; use a custom ScriptPlayable to implement this feature", False)]
        public double effectiveParentDelay { get; }
        public float effectiveParentSpeed { get; }
        public float effectiveSpeed { get; }
        public EvaluationType evaluationType { get; }
        public bool seekOccurred { get; }
        public bool timeLooped { get; }
        public bool timeHeld { get; }
        public PlayableOutput output { get; }
        public PlayState effectivePlayState { get; }
        public enum EvaluationType
        {

            Evaluate = 0,
            Playback = 1
        }
    }
}

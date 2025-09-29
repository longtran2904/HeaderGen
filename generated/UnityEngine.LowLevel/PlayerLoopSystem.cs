#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.LowLevel
{
    [MovedFrom("UnityEngine.Experimental.LowLevel")]
    public struct PlayerLoopSystem
    {
        public Type type;
        public PlayerLoopSystem[] subSystemList;
        public UpdateFunction updateDelegate;
        public nint updateFunction;
        public nint loopConditionFunction;

        public override string ToString();

        public delegate void UpdateFunction();
    }
}

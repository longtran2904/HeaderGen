#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using System;

namespace UnityEngine.Experimental.AI
{
    [Flags]
    public enum PathQueryStatus
    {

        Failure = -2147483648,
        Success = 1073741824,
        InProgress = 536870912,
        StatusDetailMask = 16777215,
        WrongMagic = 1,
        WrongVersion = 2,
        OutOfMemory = 4,
        InvalidParam = 8,
        BufferTooSmall = 16,
        OutOfNodes = 32,
        PartialResult = 64
    }
}

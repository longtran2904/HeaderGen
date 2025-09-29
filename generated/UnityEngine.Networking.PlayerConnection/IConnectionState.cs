#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Networking.PlayerConnection
{
    [MovedFrom("UnityEngine.Experimental.Networking.PlayerConnection")]
    public interface IConnectionState : IDisposable
    {

        ConnectionTarget connectedToTarget { get; }
        string connectionName { get; }
    }
}

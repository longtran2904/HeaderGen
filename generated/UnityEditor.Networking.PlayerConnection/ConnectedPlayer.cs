#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor.Networking.PlayerConnection
{
    public class ConnectedPlayer
    {
        public ConnectedPlayer();
        public ConnectedPlayer(int playerId);
        public ConnectedPlayer(int playerId, string name);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use playerId instead (UnityUpgradable) -> playerId", True)]
        public int PlayerId { get; }
        public int playerId { get; }
        public string name { get; }
    }
}

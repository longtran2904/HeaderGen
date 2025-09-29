#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine.Diagnostics
{
    public static class PlayerConnection
    {
        [Obsolete("Use UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected instead.")]
        public static bool connected { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("PlayerConnection.SendFile is no longer supported.", True)]
        public static void SendFile(string remoteFilePath, byte[] data);
    }
}

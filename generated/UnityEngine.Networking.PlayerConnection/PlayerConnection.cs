#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
    public class PlayerConnection : ScriptableObject, IEditorPlayerConnection
    {
        public PlayerConnection();

        public static PlayerConnection instance { get; }
        public bool isConnected { get; }

        public void OnEnable();
        public void Register(Guid messageId, UnityAction<MessageEventArgs> callback);
        public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback);
        public void RegisterConnection(UnityAction<int> callback);
        public void RegisterDisconnection(UnityAction<int> callback);
        public void UnregisterConnection(UnityAction<int> callback);
        public void UnregisterDisconnection(UnityAction<int> callback);
        public void Send(Guid messageId, byte[] data);
        public bool TrySend(Guid messageId, byte[] data);
        public bool BlockUntilRecvMsg(Guid messageId, int timeout);
        public void DisconnectAll();
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEditor.Networking.PlayerConnection
{
    public class EditorConnection : ScriptableSingleton<EditorConnection>, IEditorPlayerConnection
    {
        public EditorConnection();

        public List<ConnectedPlayer> ConnectedPlayers { get; }

        public void Initialize();
        public void Register(Guid messageId, UnityAction<MessageEventArgs> callback);
        public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback);
        public void RegisterConnection(UnityAction<int> callback);
        public void RegisterDisconnection(UnityAction<int> callback);
        public void UnregisterConnection(UnityAction<int> callback);
        public void UnregisterDisconnection(UnityAction<int> callback);
        public void Send(Guid messageId, byte[] data, int playerId);
        public void Send(Guid messageId, byte[] data);
        public bool TrySend(Guid messageId, byte[] data, int playerId);
        public bool TrySend(Guid messageId, byte[] data);
        public void DisconnectAll();
    }
}

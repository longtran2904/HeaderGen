#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
    public interface IEditorPlayerConnection
    {

        void Register(Guid messageId, UnityAction<MessageEventArgs> callback);
        void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback);
        void DisconnectAll();
        void RegisterConnection(UnityAction<int> callback);
        void RegisterDisconnection(UnityAction<int> callback);
        void UnregisterConnection(UnityAction<int> callback);
        void UnregisterDisconnection(UnityAction<int> callback);
        void Send(Guid messageId, byte[] data);
        bool TrySend(Guid messageId, byte[] data);
    }
}

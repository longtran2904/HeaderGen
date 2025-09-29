#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [NativeClass(null)]
    [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
    public class NetworkView : Behaviour
    {

        public NetworkView();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public Component observed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public NetworkStateSynchronization stateSynchronization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public NetworkViewID viewID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public int group { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public bool isMine { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public NetworkPlayer owner { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void RPC(string name, RPCMode mode, params object[] args);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public void RPC(string name, NetworkPlayer target, params object[] args);
    }
}

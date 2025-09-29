#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
    public class Network
    {

        public Network();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static string incomingPassword { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkLogLevel logLevel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkPlayer[] connections { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkPlayer player { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static bool isClient { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static bool isServer { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkPeerType peerType { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static float sendRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static bool isMessageQueueRunning { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static double time { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int minimumAllocatableViewIDs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static bool useNat { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static string natFacilitatorIP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int natFacilitatorPort { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static string connectionTesterIP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int connectionTesterPort { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int maxConnections { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static string proxyIP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int proxyPort { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static bool useProxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static string proxyPassword { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError InitializeServer(int connections, int listenPort, bool useNat);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError InitializeServer(int connections, int listenPort);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void InitializeSecurity();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(string IP, int remotePort);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(string IP, int remotePort, string password);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(string[] IPs, int remotePort);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(string[] IPs, int remotePort, string password);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(string GUID);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(string GUID, string password);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(HostData hostData);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkConnectionError Connect(HostData hostData, string password);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void Disconnect();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void Disconnect(int timeout);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void CloseConnection(NetworkPlayer target, bool sendDisconnectionNotification);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static NetworkViewID AllocateViewID();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static Object Instantiate(Object prefab, Vector3 position, Quaternion rotation, int group);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void Destroy(NetworkViewID viewID);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void Destroy(GameObject gameObject);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void DestroyPlayerObjects(NetworkPlayer playerID);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void RemoveRPCs(NetworkPlayer playerID);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void RemoveRPCs(NetworkPlayer playerID, int group);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void RemoveRPCs(NetworkViewID viewID);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void RemoveRPCsInGroup(int group);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void SetLevelPrefix(int prefix);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int GetLastPing(NetworkPlayer player);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int GetAveragePing(NetworkPlayer player);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void SetReceivingEnabled(NetworkPlayer player, int group, bool enabled);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void SetSendingEnabled(int group, bool enabled);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void SetSendingEnabled(NetworkPlayer player, int group, bool enabled);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static ConnectionTesterStatus TestConnection();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static ConnectionTesterStatus TestConnection(bool forceTest);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static ConnectionTesterStatus TestConnectionNAT();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static ConnectionTesterStatus TestConnectionNAT(bool forceTest);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static bool HavePublicAddress();
    }
}

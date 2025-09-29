#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;
using System.Net;
using UnityEngine.Bindings;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
    [NativeConditional("ENABLE_NETWORK && ENABLE_UNET", True)]
    [NativeHeader("Modules/UNET/UNETConfiguration.h")]
    [NativeHeader("Modules/UNET/UNetTypes.h")]
    [NativeHeader("Modules/UNET/UNETManager.h")]
    [Obsolete("The UNET transport will be removed in the future as soon a replacement is ready.")]
    public sealed class NetworkTransport
    {
        public static bool IsStarted { get; }

        public static bool DoesEndPointUsePlatformProtocols(EndPoint endPoint);
        public static int ConnectEndPoint(int hostId, EndPoint endPoint, int exceptionConnectionId, out byte error);
        public static void Init();
        public static void Init(GlobalConfig config);
        public static void Shutdown();
        [Obsolete("This function has been deprecated. Use AssetDatabase utilities instead.")]
        public static string GetAssetId(GameObject go);
        public static void AddSceneId(int id);
        public static int GetNextSceneId();
        public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port, string ip);
        public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port);
        public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout);
        public static int AddHost(HostTopology topology, int port, string ip);
        public static int AddHost(HostTopology topology, int port);
        public static int AddHost(HostTopology topology);
        public static int AddWebsocketHost(HostTopology topology, int port, string ip);
        public static int AddWebsocketHost(HostTopology topology, int port);
        public static void ConnectAsNetworkHost(int hostId, string address, int port, NetworkID network, SourceID source, NodeID node, out byte error);
        [FreeFunction("UNETManager::Get()->DisconnectNetworkHost", ThrowsException = True)]
        public static void DisconnectNetworkHost(int hostId, out byte error);
        public static NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error);
        public static int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, int bytesPerSec, float bucketSizeFactor, out byte error);
        public static int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, out byte error);
        [Obsolete("GetCurrentIncomingMessageAmount has been deprecated.")]
        public static int GetCurrentIncomingMessageAmount();
        [Obsolete("GetCurrentOutgoingMessageAmount has been deprecated.")]
        public static int GetCurrentOutgoingMessageAmount();
        [FreeFunction("UNETManager::Get()->GetIncomingMessageQueueSize", ThrowsException = True)]
        public static int GetIncomingMessageQueueSize(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingMessageQueueSize", ThrowsException = True)]
        public static int GetOutgoingMessageQueueSize(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->GetCurrentRTT", ThrowsException = True)]
        public static int GetCurrentRTT(int hostId, int connectionId, out byte error);
        [Obsolete("GetCurrentRtt() has been deprecated.")]
        public static int GetCurrentRtt(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetIncomingPacketLossCount", ThrowsException = True)]
        public static int GetIncomingPacketLossCount(int hostId, int connectionId, out byte error);
        [Obsolete("GetNetworkLostPacketNum() has been deprecated.")]
        public static int GetNetworkLostPacketNum(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetIncomingPacketCount", ThrowsException = True)]
        public static int GetIncomingPacketCount(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingPacketNetworkLossPercent", ThrowsException = True)]
        public static int GetOutgoingPacketNetworkLossPercent(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingPacketOverflowLossPercent", ThrowsException = True)]
        public static int GetOutgoingPacketOverflowLossPercent(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetMaxAllowedBandwidth", ThrowsException = True)]
        public static int GetMaxAllowedBandwidth(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetAckBufferCount", ThrowsException = True)]
        public static int GetAckBufferCount(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetIncomingPacketDropCountForAllHosts", ThrowsException = True)]
        public static int GetIncomingPacketDropCountForAllHosts();
        [FreeFunction("UNETManager::Get()->GetIncomingPacketCountForAllHosts", ThrowsException = True)]
        public static int GetIncomingPacketCountForAllHosts();
        [FreeFunction("UNETManager::Get()->GetOutgoingPacketCount", ThrowsException = True)]
        public static int GetOutgoingPacketCount();
        [FreeFunction("UNETManager::Get()->GetOutgoingPacketCount", ThrowsException = True)]
        public static int GetOutgoingPacketCountForHost(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingPacketCount", ThrowsException = True)]
        public static int GetOutgoingPacketCountForConnection(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingMessageCount", ThrowsException = True)]
        public static int GetOutgoingMessageCount();
        [FreeFunction("UNETManager::Get()->GetOutgoingMessageCount", ThrowsException = True)]
        public static int GetOutgoingMessageCountForHost(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingMessageCount", ThrowsException = True)]
        public static int GetOutgoingMessageCountForConnection(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingUserBytesCount", ThrowsException = True)]
        public static int GetOutgoingUserBytesCount();
        [FreeFunction("UNETManager::Get()->GetOutgoingUserBytesCount", ThrowsException = True)]
        public static int GetOutgoingUserBytesCountForHost(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingUserBytesCount", ThrowsException = True)]
        public static int GetOutgoingUserBytesCountForConnection(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingSystemBytesCount", ThrowsException = True)]
        public static int GetOutgoingSystemBytesCount();
        [FreeFunction("UNETManager::Get()->GetOutgoingSystemBytesCount", ThrowsException = True)]
        public static int GetOutgoingSystemBytesCountForHost(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingSystemBytesCount", ThrowsException = True)]
        public static int GetOutgoingSystemBytesCountForConnection(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingFullBytesCount", ThrowsException = True)]
        public static int GetOutgoingFullBytesCount();
        [FreeFunction("UNETManager::Get()->GetOutgoingFullBytesCount", ThrowsException = True)]
        public static int GetOutgoingFullBytesCountForHost(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->GetOutgoingFullBytesCount", ThrowsException = True)]
        public static int GetOutgoingFullBytesCountForConnection(int hostId, int connectionId, out byte error);
        [Obsolete("GetPacketSentRate has been deprecated.")]
        public static int GetPacketSentRate(int hostId, int connectionId, out byte error);
        [Obsolete("GetPacketReceivedRate has been deprecated.")]
        public static int GetPacketReceivedRate(int hostId, int connectionId, out byte error);
        [Obsolete("GetRemotePacketReceivedRate has been deprecated.")]
        public static int GetRemotePacketReceivedRate(int hostId, int connectionId, out byte error);
        [Obsolete("GetNetIOTimeuS has been deprecated.")]
        public static int GetNetIOTimeuS();
        [FreeFunction("UNETManager::Get()->GetConnectionInfo", ThrowsException = True)]
        public static string GetConnectionInfo(int hostId, int connectionId, out int port, out ulong network, out ushort dstNode, out byte error);
        public static void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error);
        [FreeFunction("UNETManager::Get()->GetNetworkTimestamp", ThrowsException = True)]
        public static int GetNetworkTimestamp();
        [FreeFunction("UNETManager::Get()->GetRemoteDelayTimeMS", ThrowsException = True)]
        public static int GetRemoteDelayTimeMS(int hostId, int connectionId, int remoteTime, out byte error);
        public static bool StartSendMulticast(int hostId, int channelId, byte[] buffer, int size, out byte error);
        [FreeFunction("UNETManager::Get()->SendMulticast", ThrowsException = True)]
        public static bool SendMulticast(int hostId, int connectionId, out byte error);
        [FreeFunction("UNETManager::Get()->FinishSendMulticast", ThrowsException = True)]
        public static bool FinishSendMulticast(int hostId, out byte error);
        [FreeFunction("UNETManager::Get()->RemoveHost", ThrowsException = True)]
        public static bool RemoveHost(int hostId);
        [FreeFunction("UNETManager::Get()->Connect", ThrowsException = True)]
        public static int Connect(int hostId, string address, int port, int exeptionConnectionId, out byte error);
        public static int ConnectWithSimulator(int hostId, string address, int port, int exeptionConnectionId, out byte error, ConnectionSimulatorConfig conf);
        [FreeFunction("UNETManager::Get()->Disconnect", ThrowsException = True)]
        public static bool Disconnect(int hostId, int connectionId, out byte error);
        public static bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error);
        public static bool QueueMessageForSending(int hostId, int connectionId, int channelId, byte[] buffer, int size, out byte error);
        [FreeFunction("UNETManager::Get()->SendQueuedMessages", ThrowsException = True)]
        public static bool SendQueuedMessages(int hostId, int connectionId, out byte error);
        public static NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
        public static NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
        [FreeFunction("UNETManager::Get()->SetPacketStat", ThrowsException = True)]
        public static void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes);
        [FreeFunction("UNETManager::Get()->NotifyWhenConnectionReadyForSend", ThrowsException = True)]
        public static bool NotifyWhenConnectionReadyForSend(int hostId, int connectionId, int notificationLevel, out byte error);
        [FreeFunction("UNETManager::Get()->GetHostPort", ThrowsException = True)]
        public static int GetHostPort(int hostId);
        public static bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error);
        [FreeFunction("UNETManager::Get()->StopBroadcastDiscovery", ThrowsException = True)]
        public static void StopBroadcastDiscovery();
        [FreeFunction("UNETManager::Get()->IsBroadcastDiscoveryRunning", ThrowsException = True)]
        public static bool IsBroadcastDiscoveryRunning();
        [FreeFunction("UNETManager::Get()->SetBroadcastCredentials", ThrowsException = True)]
        public static void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error);
        [FreeFunction("UNETManager::Get()->GetBroadcastConnectionInfoInternal", ThrowsException = True)]
        public static string GetBroadcastConnectionInfo(int hostId, out int port, out byte error);
        public static void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error);
        public static void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error);
        [FreeFunction("UNETManager::SetMulticastLock")]
        public static void SetMulticastLock(bool enabled);
        public static bool LoadEncryptionLibrary(string libraryName);
        public static void UnloadEncryptionLibrary();
        public static bool IsEncryptionActive();
        public static short GetEncryptionSafeMaxPacketSize(short maxPacketSize);
    }
}

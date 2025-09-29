#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
    [Obsolete("The UNET transport will be removed in the future as soon a replacement is ready.")]
    public class ConnectionConfig
    {

        public ConnectionConfig();
        public ConnectionConfig(ConnectionConfig config);

        public ushort PacketSize { get; set; }
        public ushort FragmentSize { get; set; }
        public uint ResendTimeout { get; set; }
        public uint DisconnectTimeout { get; set; }
        public uint ConnectTimeout { get; set; }
        public uint MinUpdateTimeout { get; set; }
        public uint PingTimeout { get; set; }
        public uint ReducedPingTimeout { get; set; }
        public uint AllCostTimeout { get; set; }
        public byte NetworkDropThreshold { get; set; }
        public byte OverflowDropThreshold { get; set; }
        public byte MaxConnectionAttempt { get; set; }
        public uint AckDelay { get; set; }
        public uint SendDelay { get; set; }
        public ushort MaxCombinedReliableMessageSize { get; set; }
        public ushort MaxCombinedReliableMessageCount { get; set; }
        public ushort MaxSentMessageQueueSize { get; set; }
        public ConnectionAcksType AcksType { get; set; }
        [Obsolete("IsAcksLong is deprecated. Use AcksType = ConnectionAcksType.Acks64", False)]
        public bool IsAcksLong { get; set; }
        public bool UsePlatformSpecificProtocols { get; set; }
        public uint InitialBandwidth { get; set; }
        public float BandwidthPeakFactor { get; set; }
        public ushort WebSocketReceiveBufferMaxSize { get; set; }
        public uint UdpSocketReceiveBufferMaxSize { get; set; }
        public string SSLCertFilePath { get; set; }
        public string SSLPrivateKeyFilePath { get; set; }
        public string SSLCAFilePath { get; set; }
        public int ChannelCount { get; }
        public int SharedOrderChannelCount { get; }
        public List<ChannelQOS> Channels { get; }

        public static void Validate(ConnectionConfig config);
        public byte AddChannel(QosType value);
        public void MakeChannelsSharedOrder(List<byte> channelIndices);
        public QosType GetChannel(byte idx);
        public IList<byte> GetSharedOrderChannels(byte idx);
    }
}

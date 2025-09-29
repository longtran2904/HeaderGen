#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.Networking
{
    [Obsolete("The UNET transport will be removed in the future as soon a replacement is ready.")]
    public class HostTopology
    {
        public HostTopology(ConnectionConfig defaultConfig, int maxDefaultConnections);

        public ConnectionConfig DefaultConfig { get; }
        public int MaxDefaultConnections { get; }
        public int SpecialConnectionConfigsCount { get; }
        public List<ConnectionConfig> SpecialConnectionConfigs { get; }
        public ushort ReceivedMessagePoolSize { get; set; }
        public ushort SentMessagePoolSize { get; set; }
        public float MessagePoolSizeGrowthFactor { get; set; }

        public ConnectionConfig GetSpecialConnectionConfig(int i);
        public int AddSpecialConnectionConfig(ConnectionConfig config);
    }
}

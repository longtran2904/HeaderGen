#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;

namespace UnityEngine.Networking
{
    [Obsolete("The UNET transport will be removed in the future as soon a replacement is ready.")]
    public class GlobalConfig
    {
        public GlobalConfig();

        public uint ThreadAwakeTimeout { get; set; }
        public ReactorModel ReactorModel { get; set; }
        public ushort ReactorMaximumReceivedMessages { get; set; }
        public ushort ReactorMaximumSentMessages { get; set; }
        public ushort MaxPacketSize { get; set; }
        public ushort MaxHosts { get; set; }
        public byte ThreadPoolSize { get; set; }
        public uint MinTimerTimeout { get; set; }
        public uint MaxTimerTimeout { get; set; }
        public uint MinNetSimulatorTimeout { get; set; }
        public uint MaxNetSimulatorTimeout { get; set; }
        public Action<int> NetworkEventAvailable { get; set; }
        public Action<int, int> ConnectionReadyForSend { get; set; }
    }
}

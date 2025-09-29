#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    [NativeHeader("Modules/UMPE/ChannelService.h")]
    [StaticAccessor("Unity::MPE::ChannelClient", StaticAccessorType.DoubleColon)]
    public class ChannelClient
    {
        public int clientId { get; }
        public string channelName { get; }
        public bool isAutoTick { get; }

        public bool IsConnected();
        public void Start(bool autoTick);
        public void Stop();
        public void Close();
        public void Tick();
        public void Send(string data);
        public void Send(byte[] data);
        public Action RegisterMessageHandler(Action<string> handler);
        public void UnregisterMessageHandler(Action<string> handler);
        public Action RegisterMessageHandler(Action<byte[]> handler);
        public void UnregisterMessageHandler(Action<byte[]> handler);
        public int NewRequestId();
        public ChannelClientInfo GetChannelClientInfo();
        public static void Send(int connectionId, byte[] data);
        public static void Close(string channelName);
        public static ChannelClient GetOrCreateClient(string channelName);
        public static void Shutdown();
        public static ChannelClientInfo GetChannelClientInfo(string channelName);
        public static int NewRequestId(int clientId);
        public static ChannelClientInfo GetChannelClientInfo(int clientId);
        public static ChannelClientInfo[] GetChannelClientList();
    }
}

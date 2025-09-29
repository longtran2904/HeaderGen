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
    [StaticAccessor("Unity::MPE::ChannelService", StaticAccessorType.DoubleColon)]
    public static class ChannelService
    {

        public static Action GetOrCreateChannel(string channelName, Action<int, byte[]> handler);
        public static Action RegisterMessageHandler(string channelName, Action<int, byte[]> handler);
        public static void UnregisterMessageHandler(string channelName, Action<int, byte[]> handler);
        public static void CloseChannel(string channelName);
        public static void Broadcast(int channelId, byte[] data);
        public static void Send(int connectionId, byte[] data);
        public static string GetAddress();
        public static int GetPort();
        public static void Start();
        public static void Stop();
        public static bool IsRunning();
        public static ChannelInfo[] GetChannelList();
        public static ChannelClientInfo[] GetChannelClientList();
        public static void Broadcast(int channelId, string data);
        public static void BroadcastBinary(int channelId, byte[] data);
        public static void Send(int connectionId, string data);
        public static int ChannelNameToId(string channelName);
    }
}

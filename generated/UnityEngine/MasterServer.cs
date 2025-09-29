#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
    public class MasterServer
    {

        public MasterServer();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static string ipAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int port { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static int updateRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static bool dedicatedServer { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void RequestHostList(string gameTypeName);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static HostData[] PollHostList();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void RegisterHost(string gameTypeName, string gameName);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void RegisterHost(string gameTypeName, string gameName, string comment);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void UnregisterHost();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The legacy networking system has been removed in Unity 2018.2. Use Unity Multiplayer and NetworkIdentity instead.", True)]
        public static void ClearHostList();
    }
}

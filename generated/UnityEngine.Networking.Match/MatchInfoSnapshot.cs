#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
    [Obsolete("The matchmaker and relay feature will be removed in the future, minimal support will continue until this can be safely done.")]
    public class MatchInfoSnapshot
    {
        public MatchInfoSnapshot();

        public NetworkID networkId { get; }
        public NodeID hostNodeId { get; }
        public string name { get; }
        public int averageEloScore { get; }
        public int maxSize { get; }
        public int currentSize { get; }
        public bool isPrivate { get; }
        public Dictionary<string, long> matchAttributes { get; }
        public List<MatchInfoDirectConnectSnapshot> directConnectInfos { get; }

        public class MatchInfoDirectConnectSnapshot
        {
            public MatchInfoDirectConnectSnapshot();

            public NodeID nodeId { get; }
            public string publicAddress { get; }
            public string privateAddress { get; }
            public HostPriority hostPriority { get; }
        }
    }
}

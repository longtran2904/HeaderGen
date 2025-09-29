#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
    [Obsolete("The matchmaker and relay feature will be removed in the future, minimal support will continue until this can be safely done.")]
    public class MatchInfo
    {

        public MatchInfo();

        public string address { get; }
        public int port { get; }
        public int domain { get; }
        public NetworkID networkId { get; }
        public NetworkAccessToken accessToken { get; }
        public NodeID nodeId { get; }
        public bool usingRelay { get; }

        public override string ToString();
    }
}

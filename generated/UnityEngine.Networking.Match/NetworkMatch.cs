#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking.Match
{
    [Obsolete("The matchmaker and relay feature will be removed in the future, minimal support will continue until this can be safely done.")]
    public class NetworkMatch : MonoBehaviour
    {

        public NetworkMatch();

        public Uri baseUri { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This function is not used any longer to interface with the matchmaker. Please set up your project by logging in through the editor connect dialog.", True)]
        public void SetProgramAppID(AppID programAppID);
        public Coroutine CreateMatch(string matchName, uint matchSize, bool matchAdvertise, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForMatch, int requestDomain, DataResponseDelegate<MatchInfo> callback);
        public Coroutine JoinMatch(NetworkID netId, string matchPassword, string publicClientAddress, string privateClientAddress, int eloScoreForClient, int requestDomain, DataResponseDelegate<MatchInfo> callback);
        public Coroutine DestroyMatch(NetworkID netId, int requestDomain, BasicResponseDelegate callback);
        public Coroutine DropConnection(NetworkID netId, NodeID dropNodeId, int requestDomain, BasicResponseDelegate callback);
        public Coroutine ListMatches(int startPageNumber, int resultPageSize, string matchNameFilter, bool filterOutPrivateMatchesFromResults, int eloScoreTarget, int requestDomain, DataResponseDelegate<List<MatchInfoSnapshot>> callback);
        public Coroutine SetMatchAttributes(NetworkID networkId, bool isListed, int requestDomain, BasicResponseDelegate callback);
        public delegate void BasicResponseDelegate(bool success, string extendedInfo);
        public delegate void DataResponseDelegate<T>(bool success, string extendedInfo, T responseData);
    }
}

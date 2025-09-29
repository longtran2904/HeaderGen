#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
    public class Utility
    {

        [Obsolete("This property is unused and should not be referenced in code.", True)]
        public static bool useRandomSourceID { get; set; }

        public static SourceID GetSourceID();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This function is unused and should not be referenced in code. Please sign in and setup your project in the editor instead.", True)]
        public static void SetAppID(AppID newAppID);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This function is unused and should not be referenced in code. Please sign in and setup your project in the editor instead.", True)]
        public static AppID GetAppID();
        public static void SetAccessTokenForNetwork(NetworkID netId, NetworkAccessToken accessToken);
        public static NetworkAccessToken GetAccessTokenForNetwork(NetworkID netId);
    }
}

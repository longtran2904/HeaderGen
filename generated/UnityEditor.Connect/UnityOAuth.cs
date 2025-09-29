#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.Connect
{
    public static class UnityOAuth
    {

        public static event Action UserLoggedIn;
        public static event Action UserLoggedOut;

        public static void GetAuthorizationCodeAsync(string clientId, Action<AuthCodeResponse> callback);
        public struct AuthCodeResponse
        {

            public string AuthCode { get; set; }
            public Exception Exception { get; set; }
        }
    }
}

#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

namespace UnityEngine.Networking.Types
{
    public class NetworkAccessToken
    {

        public byte[] array;

        public NetworkAccessToken();
        public NetworkAccessToken(byte[] array);
        public NetworkAccessToken(string strArray);

        public string GetByteString();
        public bool IsValid();
    }
}

#region UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll
#endregion

using System;

namespace UnityEngine.Networking
{
    [Obsolete("The UNET transport will be removed in the future as soon a replacement is ready.")]
    public class ConnectionSimulatorConfig : IDisposable
    {

        public ConnectionSimulatorConfig(int outMinDelay, int outAvgDelay, int inMinDelay, int inAvgDelay, float packetLossPercentage);

        ~ConnectionSimulatorConfig();

        [ThreadAndSerializationSafe]
        public void Dispose();
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    public struct ChannelClientScope : IDisposable
    {
        public ChannelClientScope(bool autoTick, string channelName, Action<string> handler, bool closeClientOnExit = True);
        public ChannelClientScope(bool autoTick, string channelName, Action<byte[]> handler, bool closeClientOnExit = True);

        public ChannelClient client { get; }

        public void Dispose();
    }
}

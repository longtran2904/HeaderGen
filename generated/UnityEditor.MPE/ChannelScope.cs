#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    public struct ChannelScope : IDisposable
    {

        public ChannelScope(string channelName, Action<int, byte[]> handler, bool closeChannelOnExit = True);

        public void Dispose();
    }
}

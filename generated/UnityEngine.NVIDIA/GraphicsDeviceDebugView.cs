#region UnityEngine.NVIDIAModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.NVIDIAModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.NVIDIA
{
    public class GraphicsDeviceDebugView
    {

        public uint deviceVersion { get; }
        public uint ngxVersion { get; }
        public IEnumerable<DLSSDebugFeatureInfos> dlssFeatureInfos { get; }
    }
}

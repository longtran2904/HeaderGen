#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/LightProbeGroup.h")]
    public sealed class LightProbeGroup : Behaviour
    {

        public LightProbeGroup();

        [NativeName("Positions")]
        public Vector3[] probePositions { get; set; }
        [NativeName("Dering")]
        public bool dering { get; set; }
    }
}

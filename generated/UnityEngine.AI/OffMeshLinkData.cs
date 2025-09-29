#region UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
    [MovedFrom("UnityEngine")]
    [NativeHeader("Modules/AI/Components/OffMeshLink.bindings.h")]
    public struct OffMeshLinkData
    {
        public bool valid { get; }
        public bool activated { get; }
        public OffMeshLinkType linkType { get; }
        public Vector3 startPos { get; }
        public Vector3 endPos { get; }
        public OffMeshLink offMeshLink { get; }
    }
}

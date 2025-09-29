#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/LOD/LODGroup.h")]
    [NativeHeader("Runtime/Graphics/LOD/LODGroupManager.h")]
    [NativeHeader("Runtime/Graphics/LOD/LODUtility.h")]
    [StaticAccessor("GetLODGroupManager()", StaticAccessorType.Dot)]
    public class LODGroup : Component
    {
        public LODGroup();

        public Vector3 localReferencePoint { get; set; }
        public float size { get; set; }
        public int lodCount { get; }
        public LODFadeMode fadeMode { get; set; }
        public bool animateCrossFading { get; set; }
        public bool enabled { get; set; }
        [StaticAccessor("GetLODGroupManager()")]
        public static float crossFadeAnimationDuration { get; set; }

        [FreeFunction("UpdateLODGroupBoundingBox", HasExplicitThis = True)]
        public void RecalculateBounds();
        [FreeFunction("GetLODs_Binding", HasExplicitThis = True)]
        public LOD[] GetLODs();
        [Obsolete("Use SetLODs instead.")]
        public void SetLODS(LOD[] lods);
        [FreeFunction("SetLODs_Binding", HasExplicitThis = True)]
        public void SetLODs([Unmarshalled] LOD[] lods);
        [FreeFunction("ForceLODLevel", HasExplicitThis = True)]
        public void ForceLOD(int index);
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace TreeEditor
{
    public class TreeGroupRoot : TreeGroup
    {
        public float adaptiveLODQuality;
        public int shadowTextureQuality;
        public bool enableWelding;
        public bool enableAmbientOcclusion;
        public bool enableMaterialOptimize;
        public float aoDensity;
        public float rootSpread;
        public float groundOffset;
        public Matrix4x4 rootMatrix;

        public TreeGroupRoot();

        public void SetRootMatrix(Matrix4x4 m);
        public override bool CanHaveSubGroups();
        public override void UpdateParameters();
    }
}

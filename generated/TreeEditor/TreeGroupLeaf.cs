#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{
    public class TreeGroupLeaf : TreeGroup
    {

        public int geometryMode;
        public Material materialLeaf;
        public GameObject instanceMesh;
        public Vector2 size;
        public float perpendicularAlign;
        public float horizontalAlign;

        public TreeGroupLeaf();

        public override bool CanHaveSubGroups();
        public override void UpdateParameters();
        public override void UpdateMatrix();
        public override void BuildAOSpheres(List<TreeAOSphere> aoSpheres);
        public override void UpdateMesh(List<TreeMaterial> materials, List<TreeVertex> verts, List<TreeTriangle> tris, List<TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
        public enum GeometryMode
        {

            PLANE = 0,
            CROSS = 1,
            TRI_CROSS = 2,
            BILLBOARD = 3,
            MESH = 4
        }
    }
}

#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{
    public class TreeGroupBranch : TreeGroup
    {

        public float lodQualityMultiplier;
        public GeometryMode geometryMode;
        public Material materialBranch;
        public Material materialBreak;
        public Material materialFrond;
        public Vector2 height;
        public float radius;
        public AnimationCurve radiusCurve;
        public bool radiusMode;
        public float capSmoothing;
        public float crinklyness;
        public AnimationCurve crinkCurve;
        public float seekBlend;
        public AnimationCurve seekCurve;
        public float noise;
        public AnimationCurve noiseCurve;
        public float noiseScaleU;
        public float noiseScaleV;
        public float flareSize;
        public float flareHeight;
        public float flareNoise;
        public float weldHeight;
        public float weldSpreadTop;
        public float weldSpreadBottom;
        public float breakingChance;
        public Vector2 breakingSpot;
        public int frondCount;
        public float frondWidth;
        public AnimationCurve frondCurve;
        public Vector2 frondRange;
        public float frondRotation;
        public float frondCrease;

        public TreeGroupBranch();

        public override float GetRadiusAtTime(TreeNode node, float time, bool includeModifications);
        public override void UpdateParameters();
        public void UpdateSplines();
        public override void UpdateMatrix();
        public override void BuildAOSpheres(List<TreeAOSphere> aoSpheres);
        public override void UpdateMesh(List<TreeMaterial> materials, List<TreeVertex> verts, List<TreeTriangle> tris, List<TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
        public void UpdateSpline(TreeNode node);
        public enum GeometryMode
        {

            Branch = 0,
            BranchFrond = 1,
            Frond = 2
        }
    }
}

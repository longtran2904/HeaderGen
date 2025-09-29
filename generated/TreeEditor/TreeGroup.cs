#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{
    public class TreeGroup
    {

        public int seed;
        public int distributionFrequency;
        public DistributionMode distributionMode;
        public AnimationCurve distributionCurve;
        public int distributionNodes;
        public float distributionTwirl;
        public float distributionPitch;
        public AnimationCurve distributionPitchCurve;
        public float distributionScale;
        public AnimationCurve distributionScaleCurve;
        public bool showAnimationProps;
        public float animationPrimary;
        public float animationSecondary;
        public float animationEdge;
        public bool visible;
        public int lockFlags;
        public int[] nodeIDs;
        public int parentGroupID;
        public int[] childGroupIDs;
        protected static readonly bool GenerateDoubleSidedGeometry;
        protected static readonly float GenerateBendNormalFactor;
        protected static readonly float GenerateBendBillboardNormalFactor;

        public TreeGroup();

        public int uniqueID { get; set; }

        public virtual float GetRadiusAtTime(TreeNode node, float t, bool includeModifications);
        public virtual bool CanHaveSubGroups();
        public void Lock();
        public void Unlock();
        public bool CheckExternalChanges();
        public void UpdateFrequency(TreeData owner);
        public void UpdateSeed();
        public Vector2 ComputeWindFactor(TreeNode node, float offset);
        public float GetRootSpread();
        public Matrix4x4 GetRootMatrix();
        public void UpdateDistribution(bool completeUpdate, bool updateSubGroups);
        public virtual void UpdateParameters();
        public virtual void BuildAOSpheres(List<TreeAOSphere> aoSpheres);
        public virtual void UpdateMesh(List<TreeMaterial> materials, List<TreeVertex> verts, List<TreeTriangle> tris, List<TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
        public virtual void UpdateMatrix();
        protected static int GetMaterialIndex(Material m, List<TreeMaterial> materials, bool tileV);
        protected static Vector4 CreateTangent(TreeNode node, Quaternion rot, Vector3 normal);
        protected static float ComputeAmbientOcclusion(Vector3 pos, Vector3 nor, List<TreeAOSphere> aoSpheres, float aoDensity);
        public enum LockFlag
        {

            LockPosition = 1,
            LockAlignment = 2,
            LockShape = 4
        }
        public enum BuildFlag
        {

            BuildAmbientOcclusion = 1,
            BuildWeldParts = 2
        }
        public enum DistributionMode
        {

            Random = 0,
            Alternate = 1,
            Opposite = 2,
            Whorled = 3
        }
    }
}

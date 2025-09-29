#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{
    public class TreeData : ScriptableObject
    {

        public string materialHash;
        public TreeGroupRoot root;
        public TreeGroupBranch[] branchGroups;
        public TreeGroupLeaf[] leafGroups;
        public TreeNode[] nodes;
        public Mesh mesh;
        public Material optimizedSolidMaterial;
        public Material optimizedCutoutMaterial;
        public bool isInPreviewMode;

        public TreeData();

        public TreeGroup GetGroup(int id);
        public TreeNode GetNode(int id);
        public void ValidateReferences();
        public void ClearReferences();
        public TreeGroup AddGroup(TreeGroup parent, Type type);
        public TreeGroup DuplicateGroup(TreeGroup g);
        public void DeleteGroup(TreeGroup g);
        public void SetGroupParent(TreeGroup g, TreeGroup parent);
        public void LockGroup(TreeGroup g);
        public void UnlockGroup(TreeGroup g);
        public bool IsAncestor(TreeGroup ancestor, TreeGroup g);
        public TreeNode AddNode(TreeGroup g, TreeNode parent);
        public TreeNode AddNode(TreeGroup g, TreeNode parent, bool validate);
        public void SetNodeParent(TreeNode n, TreeNode parent);
        public void DeleteNode(TreeNode n);
        public void DeleteNode(TreeNode n, bool validate);
        public TreeNode DuplicateNode(TreeNode n);
        public void Initialize();
        public void UpdateSeed(int id);
        public void UpdateFrequency(int id);
        public void UpdateDistribution(int id);
        public static int GetAdaptiveHeightSegments(float h, float adaptiveQuality);
        public static int GetAdaptiveRadialSegments(float r, float adaptiveQuality);
        public static List<float> GetAdaptiveSamples(TreeGroup group, TreeNode node, float adaptiveQuality);
        public void PreviewMesh(Matrix4x4 worldToLocalMatrix, out Material[] outMaterials);
        public void UpdateMesh(Matrix4x4 worldToLocalMatrix, out Material[] outMaterials);
        public bool OptimizeMaterial(List<TreeMaterial> materials, List<TreeVertex> vertices, List<TreeTriangle> triangles);
        public bool CheckExternalChanges();
        public void UpdateMesh(Matrix4x4 matrix, List<TreeMaterial> materials, List<TreeVertex> verts, List<TreeTriangle> tris, List<TreeAOSphere> aoSpheres, int buildFlags, float adaptiveQuality, float aoDensity);
    }
}

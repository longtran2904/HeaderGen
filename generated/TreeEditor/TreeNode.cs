#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace TreeEditor
{
    public class TreeNode
    {

        public TreeSpline spline;
        public int seed;
        public float animSeed;
        public bool visible;
        public int triStart;
        public int triEnd;
        public int vertStart;
        public int vertEnd;
        public float capRange;
        public float breakOffset;
        public float size;
        public float scale;
        public float offset;
        public float baseAngle;
        public float angle;
        public float pitch;
        public Quaternion rotation;
        public Matrix4x4 matrix;
        public int parentID;
        public int groupID;

        public TreeNode();

        public int uniqueID { get; set; }

        public float GetScale();
        public float GetSurfaceAngleAtTime(float time);
        public float GetRadiusAtTime(float time);
        public void GetPropertiesAtTime(float time, out Vector3 pos, out Quaternion rot, out float rad);
        public Matrix4x4 GetLocalMatrixAtTime(float time);
    }
}

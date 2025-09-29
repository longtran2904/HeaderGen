#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace TreeEditor
{
    public class TreeSpline
    {

        public SplineNode[] nodes;
        public float tension;

        public TreeSpline();
        public TreeSpline(TreeSpline o);

        public void Reset();
        public int GetNodeCount();
        public void SetNodeCount(int c);
        public void RemoveNode(int c);
        public SplineNode[] GetNodes();
        public void AddPoint(Vector3 pos, float timeInSeconds);
        public float GetApproximateLength();
        public void UpdateTime();
        public void UpdateRotations();
        public Quaternion GetRotationAtTime(float timeParam);
        public Vector3 GetPositionAtTime(float timeParam);
    }
}

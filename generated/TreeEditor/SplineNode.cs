#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace TreeEditor
{
    public class SplineNode
    {
        public Vector3 point;
        public Quaternion rot;
        public Vector3 normal;
        public Vector3 tangent;
        public float time;

        public SplineNode(Vector3 p, float t);
        public SplineNode(SplineNode o);
    }
}

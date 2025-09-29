#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace TreeEditor
{
    public class TreeAOSphere
    {
        public bool flag;
        public float area;
        public float radius;
        public float density;
        public Vector3 position;

        public TreeAOSphere(Vector3 pos, float radius, float density);

        public float PointOcclusion(Vector3 pos, Vector3 nor);
    }
}

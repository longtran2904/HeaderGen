#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace TreeEditor
{
    public class TreeVertex
    {

        public Vector3 pos;
        public Vector3 nor;
        public Vector4 tangent;
        public Vector2 uv0;
        public Vector2 uv1;
        public Color color;
        public bool flag;

        public TreeVertex();

        public void SetAnimationProperties(float primaryFactor, float secondaryFactor, float edgeFactor, float phase);
        public void SetAmbientOcclusion(float ao);
        public void Lerp4(TreeVertex[] tv, Vector2 factor);
    }
}

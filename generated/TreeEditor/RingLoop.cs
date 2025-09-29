#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TreeEditor
{
    public class RingLoop
    {

        public float radius;
        public float baseOffset;

        public RingLoop();

        public static void SetNoiseSeed(int seed);
        public RingLoop Clone();
        public void Reset(float r, Matrix4x4 m, float bOffset, int segs);
        public void SetSurfaceAngle(float angleDeg);
        public void SetAnimationProperties(float primaryFactor, float secondaryFactor, float edgeFactor, float phase);
        public void SetSpread(float top, float bottom);
        public void SetNoise(float scale, float scaleU, float scaleV);
        public void SetFlares(float radius, float noise);
        public void BuildVertices(List<TreeVertex> verts);
        public void Cap(float sphereFactor, float noise, int mappingMode, float mappingScale, List<TreeVertex> verts, List<TreeTriangle> tris, int materialIndex);
        public void Connect(RingLoop other, List<TreeTriangle> tris, int materialIndex, bool flipTris, bool lowres);
    }
}

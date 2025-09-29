#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace TreeEditor
{
    public class TreeTriangle
    {
        public bool tileV;
        public bool isBillboard;
        public bool isCutout;
        public int materialIndex;
        public int[] v;

        public TreeTriangle(int material, int v0, int v1, int v2);
        public TreeTriangle(int material, int v0, int v1, int v2, bool isBillboard);
        public TreeTriangle(int material, int v0, int v1, int v2, bool isBillboard, bool tileV, bool isCutout);

        public void flip();
    }
}

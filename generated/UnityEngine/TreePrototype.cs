#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public sealed class TreePrototype
    {

        public TreePrototype();
        public TreePrototype(TreePrototype other);

        public GameObject prefab { get; set; }
        public float bendFactor { get; set; }
        public int navMeshLod { get; set; }

        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}

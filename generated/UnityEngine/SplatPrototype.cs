#region UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll
#endregion

using UnityEngine.Scripting;

namespace UnityEngine
{
    [UsedByNativeCode]
    public sealed class SplatPrototype
    {
        public SplatPrototype();

        public Texture2D texture { get; set; }
        public Texture2D normalMap { get; set; }
        public Vector2 tileSize { get; set; }
        public Vector2 tileOffset { get; set; }
        public Color specular { get; set; }
        public float metallic { get; set; }
        public float smoothness { get; set; }
    }
}
